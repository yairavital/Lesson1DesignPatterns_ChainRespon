using Lesson1DW;

BillHandler bill200 = new BillHandler200();
BillHandler bill100= new BillHandler100();
BillHandler bill50 = new BillHandler50();   
BillHandler bill20 = new BillHandler20();
bill200.SetNextBill(bill100);
bill100.SetNextBill(bill50);
bill50.SetNextBill(bill20);
bill20.SetNextBill(null);

bill200.HandleRequest(770);
bill200.HandleRequest(210);