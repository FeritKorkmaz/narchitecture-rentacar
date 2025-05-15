# 🚗 RentACar Backend Project – Built with NArchitecture

This project is a scalable and modular vehicle rental backend system built using the principles of Clean Architecture and Domain-Driven Design. It was developed as part of the **NArchitecture** training by [Engin Demiroğ](https://www.linkedin.com/posts/engindemirog_yeni-udemy-kurslar%C4%B1m-narchitecture-yeterli-activity-7153816119626129408-WrJm).

## 🌐 Tech Stack

* ✅ ASP.NET Core Web API
* ✅ Entity Framework Core (EF)
* ✅ PostgreSQL / SQL Server
* ✅ AutoMapper & FluentValidation
* ✅ MediatR & CQRS Pattern
* ✅ JWT Authentication & Role-based Access
* ✅ Redis (optional caching)
* ✅ Serilog (structured logging)
* ✅ Clean Architecture (NArchitecture Template)

## 📁 Project Structure

```
narchitecture-rentacar/
├── corePackages/         # Core domain, application logic, and infrastructure layers
└── rentACar/             # API host project with configurations
```

## 🚀 How to Run the Project

1. **Clone the repository**:

   ```bash
   git clone https://github.com/FeritKorkmaz/narchitecture-rentacar.git
   ```

2. **Update the database** (adjust your own connection string if needed):

   ```powershell
   Update-Database
   ```

3. **Run the Web API**:

   ```bash
   cd src/rentACar/WebAPI
   dotnet run
   ```

---

# 🇹🇷 RentACar Projesi – NArchitecture Tabanlı Araç Kiralama Sistemi

Bu proje, Clean Architecture yaklaşımını temel alan modüler ve ölçeklenebilir bir araç kiralama sistemidir. **CQRS**, **MediatR**, **JWT**, **Serilog** gibi modern teknolojilerle desteklenmiş, katmanlı m m\u00eimarisi sayesinde geliştirilebilir ve sürdürülebilir bir yapı sunar.

## 🧰 Kullanılan Teknolojiler

* ✅ ASP.NET Core Web API
* ✅ Entity Framework Core
* ✅ PostgreSQL veya SQL Server
* ✅ AutoMapper & FluentValidation
* ✅ CQRS ve MediatR ile yapılandırma
* ✅ JWT ve rol bazlı yetkilendirme
* ✅ Redis (cache için)
* ✅ Serilog (yapılandırılmış loglama)
* ✅ NArchitecture (Katmanlı mımari)

## 📂 Proje Yapısı

```
narchitecture-rentacar/
├── corePackages/         # Domain, Application ve Infrastructure katmanları
└── rentACar/             # API katmanı ve konfigürasyonlar
```

## 🔧 Projeyi Çalıştırmak

1. **Projeyi klonlayın**:

   ```bash
   git clone https://github.com/FeritKorkmaz/narchitecture-rentacar.git
   ```

2. **Veritabanını güncelleyin**:

   ```powershell
   Update-Database
   ```

3. **API'yi çalıştırın**:

   ```bash
   cd src/rentACar/WebAPI
   dotnet run
   ```

---

## 🧪 Notlar

* Bu proje, eğitim amaçlı olmakla birlikte gerçek projelerde referans olarak kullanılabilecek profesyonel bir mimariye sahiptir.
* Kod yapısı SOLID prensiplerine uygun geliştirilmiştir.
* `corePackages` ile altyapı bağımsızlığı sağlanmıştır.

---

> 📢 GitHub: [FeritKorkmaz](https://github.com/FeritKorkmaz)
> 📄 License: MIT
