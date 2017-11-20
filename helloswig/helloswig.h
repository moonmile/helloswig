#pragma once
#include <string>
class Hello
{
private:
	std::string _name;
public:
	Hello();
	void SetName(const char *name);
	const char *GetName();
	int Add(int x, int y);
	int Mul(int x, int y);
};