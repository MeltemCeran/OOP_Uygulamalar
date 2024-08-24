namespace CreateInstanceHuman
{
    public interface IHuman
    {
       
        public int KolSayisi
        {
            get { return 2; }
        }

        public int BacakSayisi
        {
            get { return 2; }
        }
      
        public void InsanıOlustur();
        public void YemekYe();
        public void CisYap();
        public void Yurume();


        //IHuman revize edilmeli. Belki Varlıktaki insan olma özellikleri buraya eklenebilir. ya da insana ait tüm kalıcı özellikler varlık 
        //sınıfına konulabilir. Yani tüm insanlarda bunlar olmak zorunda ve değiştirilemez olsun. Classa koymak mantıklı interface de farklı tanımlar gerekir.
        //ben tek tanım herkes için geçerli olsun istiyorum.

        //Barışçıl mı opsiyonu tüm insanlarda olsun ve if şu ırka aitse barışçıl true olsun. o ırklar haricinde barışçıl false dönsün.

        //public void Yurume(int hız); mustafanın halkı
        //public void Yurume(int hız, double zıpla); gökhanın halkı


        //sealed ve generic.
        //createinstance.
    }
}
