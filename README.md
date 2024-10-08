# PatikaWeek12CodeFirstRelation

Bu proje, Entity Framework Core kullanarak ilişkili tablolarla veritabanı oluşturan bir Code First uygulamasıdır. Proje, Patika.dev platformunda verilen 12. hafta dersi kapsamında hazırlanmıştır ve veri modelleri arasındaki ilişkilerin nasıl yönetildiğini göstermektedir.

## 📋 İçindekiler

- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Proje Yapısı](#proje-yapısı)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)


## 🚀 Kurulum

Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:

1. Repozitory'yi klonlayın:
     git clone https://github.com/sefayilmaz14/PatikaWeek12CodeFirstRelation.git
   
2.  Projeyi Visual Studio'da açın:
PatikaWeek12CodeFirstRelation.sln dosyasını açın.

3. NuGet paketlerini geri yükleyin:
Visual Studio'da çözüm üzerine sağ tıklayıp NuGet Paketlerini Geri Yükle seçeneğini seçin.

4. Veritabanını güncelleyin:
Visual Studio’nun Package Manager Console bölümünü açın ve şu komutu çalıştırın:
update-database

## 💻 Kullanım
Proje, Entity Framework Code First yaklaşımı kullanarak bir veritabanı oluşturur. İlişkili tablolar ile veritabanı oluşturulmuş ve gerekli migration'lar eklenmiştir.

Projeyi çalıştırdıktan sonra veri modelleri ve ilişkiler üzerinde CRUD (Create, Read, Update, Delete) işlemleri yapabilirsiniz.

## 🗂️ Proje Yapısı
Proje yapısı şu şekildedir:

Entities: Veritabanı tablolarını temsil eden sınıflar.
Migrations: Veritabanı migration’larının bulunduğu klasör.
Context: Veritabanı işlemlerinin gerçekleştirildiği DbContext sınıfı.

## 🛠️ Kullanılan Teknolojiler
.NET Core
Entity Framework Core
Microsoft SQL Server
Visual Studio
