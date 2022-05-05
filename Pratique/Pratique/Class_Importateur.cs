using System;

public class Class1
{
	public Class1()
	{

         private string IdCl;

    public string IdCl1
    {
        get { return IdCl; }
        set { IdCl = value; }
    }
    private string NomCl;

    public string NomCl1
    {
        get { return NomCl; }
        set { NomCl = value; }
    }
    private string EmailCl;

    public string EmailCl1
    {
        get { return EmailCl; }
        set { EmailCl = value; }
    }
    private string PhoneCl;

    public string PhoneCl1
    {
        get { return PhoneCl; }
        set { PhoneCl = value; }
    }
    // initial
    public importateur()
    {

    }
 // modification
    public importateur(string id, string nom, string email, string phone)
    {
        this.IdCl = id;
        this.NomCl = nom;
        this.EmailCl = email;
        this.PhoneCl = phone;
    }
    // suppression
    public importateur(string id)
    {
        this.IdCl = id;
    }
}
	}
}
