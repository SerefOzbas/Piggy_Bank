# Piggy_Bank

PIGGY BANK 
Piggy Bank projesi içerisinde hepimizin bildiği “domuz kumbara” tasarlanacaktır. 
 
İlgili proje içerisinde 2 temel nesne bulunmaktadır;Kumbara ve Para 
KUMBARA 
-İçerisinde para tutacaktır. 
-Kumbara içerisindeki paralar sadece kumbara kırıldığında ( Break() ) return edilmelidir.Bu return tipi List< > olmalıdır.Para miktarına Break() metodu dışında erişim olmamalıdır. 
PARA 
-Her bir paranın kendisine ait bir ismi vardır(On kuruş , Bir Lira , Elli Lira v.b) 
-Her bir paranın kendisine ait bir değeri vardır(0.10 , 1 , 50 vb.) 
--------------------------------------------------------BONUSLAR----------------------------------------------------------- 
BONUS-1: Kumbara bir defaya mahsus yapıştırılabilir olacaktır.Yani bir kez kırılıp içerisindeki miktar görüntülenen kumbara yapıştırılıp tekrar kullanılabilir.Ancak ikinci sefer kırıldığında bir daha yapıştırılamaz.(Kırılmış olan kumbara yapıştırıldığında bakiyesi 0(sıfır) a inmelidir.) 
BONUS-2: Para nesnesini Kağıt Para(Banknote) ve Bozuk Para(Coin) olarak 2 farklı tür olarak tasarlayın. 
BONUS-3: Her bir paranın kendisine göre kapladığı bir hacim olmalıdır.Coin hacmi π.r².h ,Banknote hacmi x*y*z(en*boy*yükseklik) olarak hesaplanabilir.PI sayısı hazır kütüphaneden değil kendi oluşturduğunuz bir sabit üzerinden alınmalıdır.Kağıt paranın yükseklik değeri için NOTLAR bölümüne bakınız. 
Kumbaranında kendisine ait bir hacmi olmalıdır.Atılan her bir para kumbara hacmini arttıracaktır.Hacmi dolmuş olan kumbaraya yeni bir para atılamamalıdır. 
 
 
BONUS-4: Kağıt Para katlanabilir olmalıdır.Katlanmadan kumbaraya kağıt para atmak mümkün olmamalı.Katlanmış paranın boyu sabit kalmalı,eni normal değerinin ¼’ü haline gelmeli ve yüksekliğinin 4 katına çıktığını hesaba katmalısınız. 
 
 
BONUS-5: Kumbaramızın belirli bir hacmi vardır.İçerisine atılabilecek para miktarı sınırlıdır.Bu paraların hacminden hesaplanır.Ancak paralar kumbaraya atıldığında nizami bir şekilde yerleşmezler yani kumbaranın maksimum hacmini kullanamam.Bu durumda her para atıldığında , atılan paranın hacminin %25-%75’i oranında rastgele oluşturulacak bir fazladan kapladığı hacim olmalı ve bu kumbara hacmine eklenmeli. Shake() metodu ile kumbaramı sallayabilmeli ve içerisindeki paraların daha sıkı yerleşmelerini yani daha az hacim kaplamalarını sağlayabilirim.Shake() metodu çalıştığında kumbara içerisinde bulunan paraların fazladan kapladığı hacimler minimum değerlerine yani %25 haline gelmelidir. 
BONUS-6: Program içerisinde kullanıcıya döndüreceğim çeşitli hata mesajlarım olmalı(Kumbara hacmi doldu para atamazsınız , kağıt parayı katlamadan atamazsınız v.b).Bu hataları bir “Exception Library” içerisinde tutmalı ve gerektiği yerde bu Library üzerinden çağırmalıyım. 
BONUS-7: Program için uygun bir görsel arayüz tasarlayınız. 
 
-----------------------------------------------------------NOTLAR------------------------------------------------------------- 
*Program içerisinde güncel Türk Lirası çeşitleri kullanılacaktır.(Banknotlar & Madeni Paralar) 
*Program içerisinde güncel Türk Liralarının en,boy,yükseklik değerleri kullanılacaktır.(TL Özellikleri) 
*Yükseklik değeri olmayan banknotlar için yükseklik değeri 0,25 mm olarak kabul edilecektir.Para katlandığında oluşacak değişime dikkat edilecektir. 
*Program içerisinde oluşturduğunuz yapıda Class,Struct,Interface,Enum v.b yapıların nerede ve ne şekilde kullanılacağına siz karar vereceksiniz. 