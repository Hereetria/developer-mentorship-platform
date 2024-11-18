# Mentorlar ve Yazılım Danışmanlık Hizmeti Simülasyonu

Bu proje, mentorların site üyeliği ile yazılım danışmanlık hizmeti verdiği bir şirketin simülasyonudur. Kullanıcılar mentorlarla iletişime geçebilir ve yazılım geliştirme, kariyer rehberliği gibi alanlarda danışmanlık alabilirler. 
Projenin en önemli odak noktalarından biri, veritabanında doğru ilişkiler kurarak veri tutarlılığını ve performansını sağlamaktır.

## Proje Özellikleri

- **Kullanıcı Yönetimi**: Mentorlar ve danışmanlık almak isteyen kullanıcılar için üyelik sistemi mevcuttur.
- **Yazılım Danışmanlığı**: Kullanıcılar, ihtiyaçlarına göre mentorlarla yazılım geliştirme ve kariyer tavsiyeleri konusunda danışmanlık alabilir.
- **Çok Katmanlı Mimari**: Proje, sürdürülebilirlik ve genişletilebilirlik sağlamak için n katmanlı mimari kullanılarak tasarlanmıştır.
- **Veritabanı Tasarımı**: Veritabanı yapısı, doğru ilişkileri kurarak veri tutarlılığına ve performansa dikkat edilerek tasarlanmıştır.
  
## Teknolojiler

- **Backend**: ASP.NET Core
- **Frontend**: HTML, CSS, JavaScript (Şablon, "Sailor" adıyla internette mevcuttur)
- **Veritabanı**: Microsoft SQL Server (
- **Diğer Teknolojiler**: Entity Framework, Dependency Injection, LINQ, vb.

## Kullanılan Mimari ve Desenler

- **Katmanlı Mimari (Layered Architecture)**: Proje, katmanlı mimari desenine uygun olarak yapılandırılmıştır. Veri erişim, iş mantığı ve sunum katmanları birbirinden bağımsız bir şekilde tasarlanmıştır.
- **Repository Pattern**: Veritabanı işlemleri için Repository Pattern kullanılarak, veri erişimi soyutlanmıştır.
- **Dependency Injection**: Uygulama bileşenlerinin birbirine bağımlılığını yönetmek için Dependency Injection (DI) kullanılmıştır.
