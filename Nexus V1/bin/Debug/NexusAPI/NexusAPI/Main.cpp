#include <windows.h>
#include <iostream>
#include <chrono>
#include <thread>
using namespace std;

int main() 
{
	system("color 0A");
	
	cout << "injecting Dll \n";

	std::this_thread::sleep_for(std::chrono::milliseconds(5000));

	cout << "looking for roblox process \n";

	std::this_thread::sleep_for(std::chrono::milliseconds(5000));

	cout << "process found \n";

	std::this_thread::sleep_for(std::chrono::milliseconds(2500));

	cout << "finishing up \n";

	std::this_thread::sleep_for(std::chrono::milliseconds(5000));

	
	exit(0);

	return 0;

}