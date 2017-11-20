// helloswig.cpp : DLL アプリケーション用にエクスポートされる関数を定義します。
//

#include "stdafx.h"
#include "helloswig.h"

Hello::Hello() : _name("") {}

void Hello::SetName(const char *name ) {
	_name = std::string(name);
}

const char * Hello::GetName() {
	return _name.c_str();
}

int Hello::Add(int x, int y) { return x + y; }
int Hello::Mul(int x, int y) { return x * y; }


