# ToDoApp

##To-Do Uygulaması
Bu proje, ASP.NET Core MVC kullanılarak geliştirilen bir To-Do (Yapılacaklar Listesi) uygulamasını içerir.

##Başlangıç
Bu projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

Projeyi klonlayın:
'''bash 
git clone https://github.com/sizin-kullanici-adi/to-do-uygulamasi.git
Projeyi Visual Studio veya Visual Studio Code gibi bir geliştirme ortamında açın.
appsettings.json dosyasını düzenleyerek veritabanı bağlantı dizesini güncelleyin:

'''json
"ConnectionStrings": {
  "DefaultConnection": "VeritabanıBağlantıDizesi"
}

Proje klasöründe terminali açın ve aşağıdaki komutları sırasıyla çalıştırarak gerekli veritabanı tablolarını oluşturun:
'''bash 
dotnet ef migrations add InitialCreate
dotnet ef database update

Projeyi başlatın:

'''bash 
dotnet run
Tarayıcınızda https://localhost:5001 veya https://localhost:5000 adresine giderek uygulamayı görüntüleyin.

##Kullanılan Teknolojiler
ASP.NET Core MVC
Entity Framework Core
HTML, CSS
Veritabanı (SQL Server)

Uygulama Özellikleri
Yeni görevler ekleyebilirsiniz.
Silme işlemi yapabilirsiniz.
Filtreleme işlemi yapabilirsiniz.
Görevleri tamamlandı olarak işaretleyebilirsiniz.

##Katkıda Bulunma
Eğer bu projeye katkıda bulunmak isterseniz, lütfen aşağıdaki adımları takip edin:

Bu projeyi çatallayın (fork).
Yeni bir özellik ekleyin veya bir hata düzeltmesi yapın.
Değişikliklerinizi açıklayıcı bir şekilde açıklayan bir pull isteği (pull request) gönderin.
Lisans
Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için Lisans Dosyası dosyasına başvurun.

##İletişim
Herhangi bir sorunuz veya geri bildiriminiz varsa, lütfen benimle iletişime geçmekten çekinmeyin.

- E-posta: [sap_al@hotmail.com](mailto:sap_al@hotmail.com)
- GitHub: [GitHub Profili](https://github.com/SeniourMarquies)









