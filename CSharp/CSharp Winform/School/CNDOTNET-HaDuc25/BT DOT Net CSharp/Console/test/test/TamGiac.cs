using System;

namespace test
{
    class TamGiac
    {
        #region Khai bao
        //ctrl + r,e
        private double canhA;
        private double canhB;
        private double canhC;

        public double CanhA { get => canhA; set => canhA = value; }
        public double CanhB { get => canhB; set => canhB = value; }
        public double CanhC { get => canhC; set => canhC = value; }
        #endregion

        #region isTriangle 
        public void isTriangle()
        {
            double chuVi = CanhA + CanhB + CanhC;
            double temp = chuVi / 2;
            double dienTich = Math.Sqrt(temp * (temp - CanhA) * (temp - CanhB) * (temp - CanhC));

            Console.WriteLine("Chu vi tam giac: {0}, Dien Tich tam giac: {1}", chuVi, Math.Round(dienTich, 3));

            if (CanhA < CanhB + CanhC && CanhB < CanhA + CanhA + CanhC && CanhC < CanhA + CanhB)
            {
                if (CanhA * CanhA == CanhB * CanhB + CanhC * CanhC || CanhB * CanhB == CanhA * CanhA + CanhC * CanhC || CanhC * CanhC == CanhA * CanhA + CanhB * CanhB)
                {
                    Console.WriteLine("=>Day la tam giac vuong!");
                }
                else if (CanhA == CanhB && CanhB == CanhC)
                {
                    Console.WriteLine("=>Day la tam giac deu!");
                }
                else if (CanhA == CanhB || CanhA == CanhC || CanhB == CanhC)
                {
                    Console.WriteLine("=>Day la tam giac can");
                }
                else
                {
                    Console.WriteLine("=>Day la tam giac thuong");
                }
            }
            else
            {
                Console.WriteLine("Canh A, B, C khong phai la 3 canh cua mot tam giac");
            }
        }
        #endregion

        #region Nhap, Xuat
        public void Nhap()
        {
            Console.Write("Nhap canh A: ");
            this.CanhA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh B: ");
            this.CanhB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh C: ");
            this.CanhC = Convert.ToDouble(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Canh A: " + this.CanhA);
            Console.WriteLine("Canh B: " + this.CanhB);
            Console.WriteLine("Canh C: " + this.CanhC);
        }
        #endregion
    }
}
