#pragma once

//#include <iostream>;
//#include <string>;
#include "Result.h"
class MyCalc
{
public:
	MyCalc();
	virtual ~MyCalc();
	virtual void DoMath(int n1, int n2, Result& r) {
		r.addResult = add(n1, n2);
		r.mulResult = Mul(n1, n2);
	};
	virtual int add(int, int) { return 0; };
	virtual int Mul(int, int) { return 0; };
	virtual void Print(std::string v) {/* std::cout << v << " ::::printed from c++" << std::endl; */ };
};

MyCalc::MyCalc()
{
}

MyCalc::~MyCalc()
{
}
