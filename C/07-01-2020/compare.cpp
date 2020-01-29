#include<stdio.h>

int main()
{
	int array[] = {10,15,20};
	int array2[] = {10,20,30};
	int array3[] = {30,40,50};
	int array4[sizeof(array)/sizeof(array[0])]; 
	
	for(int i =0; i< sizeof(array)/sizeof(array[0]); i++)
	{
		for(int j = 0; j < sizeof(array)/sizeof(array[0]); j++)
		{
			if(array[i] == array2[j] && array[i] == array3[j])
			{
				array4[j] = array[i];
				printf("%d ", array4[j]);
			}
		}
	}
}
