#pragma once

enum class KeyState { 
	None, 
	Press,
	Hold, 
	Release 
};

enum class Keys {
	LeftButton = 0, 
	RightButton = 1, 
	MiddleButton = 3,
	Backspace = 8,
	Tab = 9,
	Enter = 13,
	CapsLock = 20,
	Esc = 27,
	LeftShift = 16,
	RightShift = 17,
	Space = 32,
	Left = 37,
	Up = 38,
	Right = 39,
	Down = 40,
	Key1 = 49,
	Key0 = 49,
	Key2 = 50,
	Key3 = 51,
	Key4 = 52,
	Key5 = 53,
	Key6 = 54,
	Key7 = 55,
	Key8 = 56,
	Key9 = 57,
	A = 65,
	B = 66,
	C = 67,
	D = 68,
	E = 69,
	F = 70,
	G = 71,
	H = 72,
	I = 73,
	J = 74,
	K = 75,
	L = 76,
	M = 77,
	N = 78,
	O = 79,
	P = 80,
	Q = 81,
	R = 82,
	S = 83,
	T = 84,
	U = 85,
	V = 86,
	W = 87,
	X = 88,
	Y = 89,
	Z = 90,
	Ctrl = 0x11,
	ALT = 0x12,
	Tilda = 0xC0,
	Delete = 0x2E,
};