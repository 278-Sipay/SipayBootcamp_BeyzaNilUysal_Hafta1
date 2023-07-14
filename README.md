### PROJE ADIMLARI:
1) Projeye FluentValidation paketi dahil edildi.
2) Models adında oluşturulan klasöre istenen Person modeli doğru veri tipleri ile oluşturuldu.
3) Controller klasörü içinde Person modelinin işleyişini kontrol eden Person adlı bir controller oluşturuldu.
4) Oluşturulan FluentValidator klasöründe Person classı için validasyon işlemleri yapıldı. 

### EK BİLGİLENDİRME: 
#### *Validasyon Nedir?*
Validasyon işlemi, bir verinin belirli kurallara uyup uymadığını kontrol ederek geçerlilik durumunu belirlemektedir. Örneğin, bir form üzerindeki alanların boş olmaması, belirli bir karakter sınırlamasına uyması veya doğru formatta olması gibi kurallar, veri validasyonunun bir parçası olabilir.

#### *FluentValidation Nedir, Ne için kullanılır?*

FluentValidation, bir .NET kütüphanesidir ve model doğrulama işlemlerini kolaylaştırmak için kullanılır. Bu kütüphane, nesne tabanlı doğrulama kurallarının açık ve akıcı bir şekilde tanımlanmasını sağlar.

FluentValidation'ın temel amacı, gelen verilerin belirli bir modele uygun olup olmadığını kontrol etmektir. Özellikle kullanıcı girişi gibi dışarıdan alınan verilerin doğruluğunu kontrol etmek için sıklıkla kullanılır. Verinin belirli bir modele uygun olması, veri bütünlüğünü sağlamak ve hatalı veri girişlerini engellemek açısından önemlidir.

#### *Model Sınıfları Nedir, Ne için kullanılır?*
Model sınıfları, bir uygulama içinde kullanılan veri yapısını, nesneleri veya varlıkları temsil etmek için kullanılır. Bu modeller, verilerin saklanmasına, taşınmasına ve işlenmesine yardımcı olur.

Bu modeller, genellikle veritabanı işlemleri, veri geçişi, API istekleri ve uygulama içindeki diğer veri manipülasyonları gibi senaryolarda kullanılır. Model sınıfları, verilerin tutarlı ve yapılandırılmış bir şekilde kullanılmasını sağlar ve uygulama içinde veri akışını kolaylaştırır.

#### *Controller Nedir, Ne için kullanılır?*
Controller'ın temel amacı, gelen istekleri almak, işlemek ve uygun yanıtları oluşturarak kullanıcı ile etkileşimde bulunmaktır. Bir Controller, kullanıcıdan gelen istekleri karşılar, ilgili iş mantığını yürütür ve sonuçları geri döner.

Controller, bir yazılım uygulamasının kullanıcı arabirimini (UI) işleyen ve iş mantığını yöneten önemli bir bileşendir. İstekleri alır, işler, verileri işler, yanıtları oluşturur ve sonuçları kullanıcıya sunar. Bu sayede, uygulama işlevselliğini sağlar ve kullanıcılarla etkileşimi yönetir.

