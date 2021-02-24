# ReCapProject - ARABA KİRALAMA SİSTEMİ (Kodlama.io)


![rentacar](https://user-images.githubusercontent.com/33182036/108623628-02053200-7451-11eb-9529-f7c2ced49fc1.jpg)

:heavy_check_mark: _Bu proje Yazılım Geliştirici Yetiştirme Kampı'nda yapılan çalışmaları kapsayan Araba Kiralama Sistemi'dir._

## 📌İÇERİK
Bu proje Araba Kiralama iş yerlerine yönelik bir projedir.Hem kurumsal mimariye hemde SOLID prensiplerine uygun olarak 
kendimizi tekrar etmeyeceğimiz şekilde yazmaya çalışıyorum. N-Katmanlı mimari yapısı ile hazırladığım proje henüz tamamlanmamış olup geliştirme aşamasındayım.

## 📌KATMANLAR

**1. ENTITIES LAYER** : Veritabanı nesneleri için oluşturduğumuz katmandır. 
-
 :open_file_folder: Abstract
- :page_with_curl: [IEntity.cs](https://github.com/fatmacafri/ReCapProject/blob/master/Entities/Abstract/IEntity.cs)

:open_file_folder: Concrete
- :page_with_curl: [Car.cs](https://github.com/fatmacafri/ReCapProject/blob/master/Entities/Concrete/Car.cs)

**2. DATA ACCESS LAYER** : Veritabanı CRUD işlemleri gerçekleştirmek için oluşturulan katmandır.
-
:open_file_folder: Abstract
- :page_with_curl: [ICarDal.cs](https://github.com/fatmacafri/ReCapProject/blob/master/DataAccess/Abstract/ICarDal.cs)

:open_file_folder: Concrete
   - :open_file_folder: InMemory
	 - :page_with_curl: [InMemoryCarDal.cs](https://github.com/fatmacafri/ReCapProject/blob/master/DataAccess/Concrete/InMemory/InMemoryCarDal.cs)

:round_pushpin: Bu katmanda Entities katmanından faydalanacağız o yüzden referans olarak Entities katmanını eklemeliyiz.

**3. BUSINESS LAYER** : Sunum katmanından gelen bilgileri gerekli koşullara göre işlemek veya denetlemek için oluşturulan katmandır.(İş kodlarını yazdığımız katmandır.)
-
:open_file_folder: Abstract
- :page_with_curl: [ICarService.cs.cs](https://github.com/fatmacafri/ReCapProject/blob/master/Business/Abstract/ICarService.cs)

:open_file_folder: Concrete
- :page_with_curl: [CarManager.cs](https://github.com/fatmacafri/ReCapProject/blob/master/Business/Concrete/CarManager.cs)

:round_pushpin: Bu katmana hem Entities hemde Data Access katmanlarını referans olarak eklemeliyiz.

**4. CONSOLE UI LAYER** : Yaptığımız işlemlerin sonuçlarını göreceğimiz katmandır.
-
- :page_with_curl: [Program.cs](https://github.com/fatmacafri/ReCapProject/blob/master/ConsoleUI/Program.cs)

:round_pushpin: Entities,DataAccess ve Business katmanlarını referans olarak eklemeliyiz.

:arrow_right: **Abstract** klasörlerinde soyut nesneler yani referans tutucular yer alır. Bunlar interface'ler, abstract class'lar ve base class'lardır.

:arrow_right: **Concrete** klasörlerinde ise somut nesneler yani gerçek işi yapan class'lar yer alır.Interface'lerin implement edildiği yerdir.

:exclamation:
:heavy_exclamation_mark: Bu ayrım sayesinde uygulamalar arasındaki bağımlılıkları en aza indiriyor olacağız.


	
	
	
