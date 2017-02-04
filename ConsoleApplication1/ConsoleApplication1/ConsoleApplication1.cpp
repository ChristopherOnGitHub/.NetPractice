// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

int main()
{
	std::cout << "Hello World!";
	std::cout << "This is my first C++ program";
	std::cout << "Let's add two numbers!";
	std::cout << "Enter two numbers:";
	int num1;
	int num2;

	std::cin >> num1;
	std::cin >> num2;
	int sum = num1 + num2;
	std::cout << sum;

	int pause;
	std::cin >> pause;
    return 0;
}

