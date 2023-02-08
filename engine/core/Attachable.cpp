#include "Attachable.h"

#include "Game.h"
#include "Player.h"
#include "MeshAsset.h"
#include "HotKeys.h"

#include "MeshComponent.h"


Material* Attachable::s_meshMaterial = nullptr;
Material* Attachable::s_boundMaterial = nullptr;
size_t Attachable::s_attachableCount = 0;

DEF_PURE_COMPONENT(Attachable, RunMode::PlayOnly);

void Attachable::OnInit() {
	m_mesh = AddComponent<MeshComponent>();
	m_bound = AddComponent<MeshComponent>();

	if (s_attachableCount == 0) {
		auto meshAsset = game()->meshAsset();

		s_meshMaterial = meshAsset->CreateDynamicMaterial("Generated by Attachaable", Assets::ShaderDiffuseColor);
		s_boundMaterial = meshAsset->CreateDynamicMaterial("Generated by Attachaable", Assets::ShaderDiffuseColor);

		s_meshMaterial->data.diffuseColor = { 0.8, 0.2, 0.4, 1.0 };
		s_boundMaterial->data.diffuseColor = { 0, 0.6, 0, 1 };
	}

	s_attachableCount++;
}

void Attachable::OnDestroy() {
	m_mesh->RemoveMaterials();
	m_bound->RemoveMaterials();

	s_attachableCount--;

	if (s_attachableCount == 0) {
		game()->meshAsset()->DeleteDynamicMaterial(s_meshMaterial);
		game()->meshAsset()->DeleteDynamicMaterial(s_boundMaterial);
	}
}

void Attachable::OnStart() {
	auto meshAsset = game()->meshAsset();
	float boxSize = boundRadius * 2 * 0.5;
	
	m_mesh->mesh(meshAsset->GetMesh(MeshAsset::formBox));
	m_mesh->SetMaterial(0, s_meshMaterial);
	m_mesh->meshScale = { boundRadius, boundRadius, boundRadius };

	m_bound->mesh(meshAsset->GetMesh(MeshAsset::formSphereLined));
	m_bound->SetMaterial(0, s_boundMaterial);
	m_bound->meshScale = { boundRadius * 2, boundRadius * 2, boundRadius * 2 };

	m_mesh->visible = showCenter;
	m_bound->visible = showBound;
}

void Attachable::OnUpdate() {

	if (game()->hotkeys()->GetButtonDown(Keys::Y)) {
		m_mesh->visible = true;
		m_bound->visible = true;
	}

	if (game()->hotkeys()->GetButtonDown(Keys::U)) {
		m_mesh->visible = false;
		m_bound->visible = false;
	}

	if (player != nullptr && player->IsDestroyed())
		player = nullptr;

	if (player == nullptr)
		return;

	if (!m_canAttach) {
		if ((boundRadius / player->radius) <= 0.8f) {
			m_canAttach = true;
			m_bound->visible = true && showBound;
		}
	}

	if (!m_canAttach)
		return;

	auto playerPos = player->worldPosition();
	auto dist = (worldPosition() + boundCenter - playerPos).Length();

	if (dist <= boundRadius + player->radius) {

		if(actor()->HasParent() && attachParent)
			player->Attach(actor()->parent());
		else 
			player->Attach(actor());
				
		player = nullptr;
	}
}