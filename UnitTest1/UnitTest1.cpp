#include "pch.h"
#include "CppUnitTest.h"
#include "C:\Users\Елизавета\source\repos\UnitTest1\ConsoleApplication1\bubblesort.cpp"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(UnitTest1)
	{
	public:

		TEST_METHOD(InputTestMethod1)
		{
			BubbleSort A;
			int i;
			int Array[] = { 5, 4, 5, 2, 9 };
			int size = sizeof(Array);
			Input_bs(Array, 5);
			Assert::IsTrue(5 == size);
		}
	};


	TEST_CLASS(UnitTest2)
	{
	public:

		TEST_METHOD(InputTestMethod2)
		{
			BubbleSort A;
			int Array[] = { 5, 4, 5, 2, 9 };
			Input_bs(Array, 5);
			int x = Array[0];
			Assert::IsTrue(1 == x);
		}
	};


	TEST_CLASS(UnitTest3)
	{
	public:

		TEST_METHOD(SortTestMethod3)
		{
			BubbleSort A;
			const unsigned int count = 5;
			int Array[count] = { 3, 6, 1, 7, 4 };
			int SortArray[count] = { 1, 3, 4, 6, 7 };

			A.bubblesort(Array, count);
			for (int i = 0; i < count; i++)
			{
				Assert::AreEqual(SortArray[i], Array[i]);
			}

		};
	};


}
