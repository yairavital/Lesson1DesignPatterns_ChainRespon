using ChainOfResponsibility_HW;
Car c1 = new Car("Mazda",true);
Car c2 = new Car("Kia", true);
Car c3 = new Car("Fiat", true);
Car c4 = new Car("Volvo", false);
Car c5 = new Car("Jook", true);
Car c6 = new Car("BMW", false);
Garge garge = new Garge();
garge.cars.Add(c1);
garge.cars.Add(c2);
garge.cars.Add(c3);
garge.cars.Add(c4);
garge.cars.Add(c5);
garge.cars.Add(c6);

CheckClassAbs firstCheck = new FirstCheck();
CheckClassAbs insOfAssemb = new InspectionOfAssembliescs();
CheckClassAbs electricianTest = new ElectricianTest();
CheckClassAbs diagnosis = new Diagnosis();
firstCheck.NextCheck(insOfAssemb);
insOfAssemb.NextCheck(electricianTest);
electricianTest.NextCheck(diagnosis);
diagnosis.NextCheck(null);
garge.cars.ForEach(c1 => { if (c1.IsNeedRepair == true) firstCheck.HandleCar(c1); });

