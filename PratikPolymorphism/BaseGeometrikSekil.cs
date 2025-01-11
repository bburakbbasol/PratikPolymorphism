using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikPolymorphism
{
	// Temel geometrik şekil sınıfı
	public class BaseGeometrikSekil
	{
		private int _uzunluk;
		private int _genislik;

		// Uzunluk özelliği
		public int Uzunluk
		{
			get { return _uzunluk; }
			set
			{
				if (value > 0)
				{
					_uzunluk = value;
				}
				else
				{
					Console.WriteLine("Sıfırdan büyük olmalı");
				}
			}
		}

		// Genişlik özelliği
		public int Genislik
		{
			get { return _genislik; }
			set
			{
				if (value > 0)
				{
					_genislik = value;
				}
				else
				{
					Console.WriteLine("Sıfırdan büyük olmalı");
				}
			}
		}

		// Sanal alan metodu
		public virtual void Alan()
		{
		}
	}

	// Kare sınıfı, BaseGeometrikSekil'den türetilir
	public class Kare : BaseGeometrikSekil
	{
		public override void Alan()
		{
			Console.WriteLine($"Karenin alanı: {Uzunluk * Genislik}");
		}
	}

	// Dikdörtgen sınıfı, BaseGeometrikSekil'den türetilir
	public class Diktortgen : BaseGeometrikSekil
	{
		public override void Alan()
		{
			if (Uzunluk == Genislik)
			{
				Console.WriteLine($"Diktörgenin alanı: {Uzunluk * Genislik}");
			}
			else
			{
				Console.WriteLine("Karenin uzunluğu ve genişliği eşit olmalı");
			}
		}
	}

	// Üçgen sınıfı, BaseGeometrikSekil'den türetilir
	public class Ucgen : BaseGeometrikSekil
	{
		public override void Alan()
		{
			Console.WriteLine($"Üçgenin alanı: {(Uzunluk * Genislik) / 2}");
		}
	}
}
