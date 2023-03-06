using System;

class Haromszog
{
    private int a;
    private int b;
    private int c;
    private double terulet;
    private double kerulet;

    public Haromszog() { }
    public Haromszog(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public void setA(int a) { this.a = a; }
    public void setB(int b) { this.b = b; }
    public void setC(int c) { this.c = c; }
    public int getA() { return this.a; }
    public int getB() { return this.b; }
    public int getC() { return this.c; }


    public void setKerulet()
    { this.kerulet = a + b + c; }
    public double getKerulet()
    { return this.kerulet; }
    public void setTerulet()
    {
        double s = (this.a + this.b + this.c) / 2;
        this.terulet = Math.Round(Math.Sqrt(s * (s - this.a) * (s - this.b) * (s - this.c)), 2);
    }
    public double getTerulet()
    { return this.terulet; }
}
class Hhasab : Haromszog
{
    private double terfogat;
    private double felszin, m;


    public Hhasab() : base() { }
    public Hhasab(int a, int b, int c, int m) : base(a, b, c)
    {
        this.m = m;
    }
    public void setHaromszog()
    {
        base.setKerulet();
        base.setTerulet();
    }
    public void setTerfogat()
    { this.terfogat = base.getTerulet() * this.m; }
    public void setFelszin()
    { this.felszin = base.getKerulet() * this.m + 2 * base.getTerulet(); }
    public double getTerfogat() { return this.terfogat; }
    public double getFelszin() { return this.felszin; }
}
