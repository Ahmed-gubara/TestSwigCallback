#pragma once

#include <iostream>;
#include <string>;
class MyCalc
{
public:
	MyCalc();
	~MyCalc();
	void DoMath();
	virtual int add(int, int) { return 0; };
	virtual int Mul(int, int) { return 0; };
	virtual void Print(std::string v) { std::cout << v << " ::::printed from c++" << std::endl; };
};

MyCalc::MyCalc()
{
}

MyCalc::~MyCalc()
{
}

inline void MyCalc::DoMath()
{
	Print("printing something");
}
