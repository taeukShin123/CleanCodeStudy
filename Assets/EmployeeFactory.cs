using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee
{
    public abstract bool isPayDay();
    public abstract Money calculatePay();
    public abstract void deliveryPay(Money pay);

}
public class Money
{

}

public interface IEmployeeFactory
{
    public Employee makeEmployee(EmployeeRecord e);
}

public enum EmployeeRecord
{
    COMMISSIONED,
    HOURLY,
    SALARIED
}

public class EmployeeFactory : MonoBehaviour, IEmployeeFactory
{
    public class CommisionedEmployee : Employee
    {
        private EmployeeRecord e;

        public CommisionedEmployee(EmployeeRecord e)
        {
            this.e = e;
        }

        public override Money calculatePay()
        {
            throw new System.NotImplementedException();
        }

        public override void deliveryPay(Money pay)
        {
            throw new System.NotImplementedException();
        }

        public override bool isPayDay()
        {
            throw new System.NotImplementedException();
        }
    }
    public class HourlyEmployee : Employee
    {
        private EmployeeRecord e;
        public int Salary { get; set; }

        public HourlyEmployee(EmployeeRecord e)
        {
            this.e = e;
        }

        public override Money calculatePay()
        {
            print("HourlyEmployee_calculatePay()");
            Money m = new();
            return m;
        }

        public override void deliveryPay(Money pay)
        {
            throw new System.NotImplementedException();
        }

        public override bool isPayDay()
        {
            throw new System.NotImplementedException();
        }
    }
    public class SalariedEmployee : Employee
    {
        private EmployeeRecord employeeRecord;

        public SalariedEmployee(EmployeeRecord e)
        {
            this.employeeRecord = e;
        }

        public override Money calculatePay()
        {
            throw new System.NotImplementedException();
        }

        public override void deliveryPay(Money pay)
        {
            throw new System.NotImplementedException();
        }

        public override bool isPayDay()
        {
            throw new System.NotImplementedException();
        }
    }
    public class InvalidEmployeeType : Employee
    {
        private EmployeeRecord employeeRecord;

        public InvalidEmployeeType(EmployeeRecord e)
        {
            this.employeeRecord = e;
        }

        public override Money calculatePay()
        {
            throw new System.NotImplementedException();
        }

        public override void deliveryPay(Money pay)
        {
            throw new System.NotImplementedException();
        }

        public override bool isPayDay()
        {
            throw new System.NotImplementedException();
        }
    }

    public Employee makeEmployee(EmployeeRecord e)
    {
        switch(e)
        {
            case EmployeeRecord.COMMISSIONED:
                return new CommisionedEmployee(e);
            case EmployeeRecord.HOURLY:
                return new HourlyEmployee(e);
            case EmployeeRecord.SALARIED:
                return new SalariedEmployee(e);
            default:
                return new InvalidEmployeeType(e);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Employee a = makeEmployee(EmployeeRecord.HOURLY);
        a.calculatePay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
