// Fill out your copyright notice in the Description page of Project Settings.

#include "CallLIbFunctions.h"
#include "../ThirdParty/Includes/Test.h"




// Sets default values for this component's properties
UCallLIbFunctions::UCallLIbFunctions()
{
	// Set this component to be initialized when the game starts, and to be ticked every frame.  You can turn these features
	// off to improve performance if you don't need them.
	PrimaryComponentTick.bCanEverTick = true;

	// ...
}


// Called when the game starts
void UCallLIbFunctions::BeginPlay()
{
	Super::BeginPlay();







	//int c=	p->Add(a,b);




}


// Called every frame
void UCallLIbFunctions::TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);

	// ...
}
int UCallLIbFunctions::LibTest(int a, int b)
{
	myclass *p;
	//p = new myclass();
	p = nullptr;
	return	p->show(a,b);

	//return P->show(a, b);


}

