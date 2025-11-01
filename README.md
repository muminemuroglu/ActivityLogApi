# 🏋️‍♀️ ActivityLogAPI

**ActivityLogAPI**, kullanıcıların **egzersiz aktivitelerini (Workout)** ve **hedeflerini (Goal)** kaydedip takip edebildiği bir **ASP.NET Core REST API** projesidir.  
JWT tabanlı kimlik doğrulama, DTO yapısı, servis katmanı, global hata yönetimi ve Swagger entegrasyonu içerir.

---

## 📅 Proje Bilgileri

- **Başlangıç Tarihi:** 1 Kasım 2025  
- **Teslim Tarihi:** 1 Kasım 2025  
- **Teknoloji:** ASP.NET Core 8.0  
- **Veritabanı:** SQLite  
- **Kimlik Doğrulama:** JWT (JSON Web Token)

---

## 🎯 Amaç

Kullanıcıların sisteme kayıt olabileceği, giriş yapabileceği ve aşağıdaki işlemleri gerçekleştirebileceği bir backend API geliştirmek:

- Egzersiz aktivitelerini (**Workout**) kaydetmek ve yönetmek  
- Hedeflerini (**Goal**) belirlemek ve ilerlemeyi takip etmek  

> Bu API **rol tabanlı değildir** — her kullanıcı yalnızca kendi verileri üzerinde işlem yapabilir.

---

## 🧱 Proje Katmanları

### 1. **Controllers**

| Controller | Açıklama |
|-------------|-----------|
| `UserController` | Kullanıcı **kayıt** ve **giriş** işlemlerini yapar. |
| `WorkoutController` | Workout CRUD (Create, Read, Update, Delete) işlemlerini yürütür. |
| `GoalController` | Goal CRUD işlemlerini yürütür. |

> 🔒 **Workout** ve **Goal** işlemleri `[Authorize]` attribute’u gerektirir.

---

### 2. **DTO (Data Transfer Object)**

Veri doğrulama ve dış dünyaya açık alanların yönetimi için DTO yapısı kullanılmıştır.  
Örnek sınıflar:  
- `WorkoutCreateDto`  
- `GoalCreateDto`  
- `UserLoginDto`  
- `UserRegisterDto`

---

### 3. **Entities & DbContext**

Veritabanı varlıkları (`User`, `Workout`, `Goal`) Entity Framework Core ile yönetilir.  
`ApplicationDbContext` sınıfı tüm tabloları ve ilişkileri içerir.

---

### 4. **Services**

İş mantığı (**Business Logic**) servis katmanında yönetilir.  
Her controller, kendi ilgili servis katmanını kullanır:

- `UserService`
- `WorkoutService`
- `GoalService`

---

### 5. **AutoMapper**

Entity ↔ DTO dönüşümleri için AutoMapper konfigürasyonu yapılmıştır.  
Bu sayede model dönüşümleri kolaylaştırılmış ve kod tekrarları azaltılmıştır.

---

### 6. **Middleware (GlobalExceptionHandler)**

Tüm hatalar `GlobalExceptionHandler` middleware’i tarafından yakalanır ve  
JSON formatında anlamlı hata mesajlarıyla döndürülür:

```json
{
  "status": 500,
  "message": "An unexpected error occurred."
}
```

---

### 7. **Migrations**

- ORM: **Entity Framework Core**  
- Veritabanı: **SQLite**

Migration işlemleri için kullanılan komutlar:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

### 8. **Swagger & JWT Entegrasyonu**

Proje, Swagger üzerinden test edilebilir şekilde yapılandırılmıştır.  
Swagger arayüzünde JWT token girilerek kimlik doğrulaması yapılabilir.

---

## 💻 Teknik Altyapı (Technical Stack)

| Bileşen | Teknoloji |
|----------|------------|
| **Framework** | .NET 8.0 (ASP.NET Core Web API) |
| **Veritabanı** | SQLite (Entity Framework Core 8 ile yönetilir) |
| **Kimlik Doğrulama** | JWT (JSON Web Token) |
| **ORM** | Entity Framework Core 8 |
| **API Dokümantasyonu** | Swagger (OpenAPI) |
| **Nesne Eşleştirme** | AutoMapper |
| **Bağımlılık Yönetimi** | Yerleşik Dependency Injection (DI) |
| **Parola Hashing** | BCrypt.Net-Next |

---

## 🧪 API Kullanım Akışı

### 1️⃣ Kayıt Ol  
`POST /api/user/register`  
```json
{
  "firstname": "Ali",
  "lastname": "Çakır",
  "email": "ali@mail.com",
  "password": "aA123456"
}
```

### 2️⃣ Giriş Yap (Token Al)  
`POST /api/user/login`

### 3️⃣ Workout Ekle  
`POST /api/workouts`  
> Header: `Authorization: Bearer <token>`

### 4️⃣ Goal Güncelle  
`PUT /api/goals/{id}`

---

## ⚙️ Kurulum

```bash
# Repoyu klonla
git clone https://github.com/muminemuroglu/ActivityLogApi
```

```bash
# Proje dizinine gir
cd ActivityLogApi
```

```bash
# Bağımlılıkları yükle
dotnet restore
```

```bash
# Migration oluştur ve veritabanını güncelle
dotnet ef database update
```

```bash
# Uygulamayı başlat
dotnet run
```

API varsayılan olarak şu adreste çalışır:  
```
http://localhost:5193
```

Swagger arayüzü:  
```
http://localhost:5193/swagger
```

---

## 📁 Proje Yapısı

```
ActivityLogAPI/
│
├── Controllers/
│   ├── UserController.cs
│   ├── WorkoutController.cs
│   └── GoalController.cs
│
├── Dto/
│   ├── WorkoutDto/
│   ├── GoalDto/
│   └── UserDto/
│
├── Models/
│   ├── User.cs
│   ├── Workout.cs
│   └── Goal.cs
│
├── Services/
│   ├── UserService.cs
│   ├── WorkoutService.cs
│   └── GoalService.cs
│
├── Middleware/
│   └── GlobalExceptionHandler.cs
│
├── Mappings/
│   └── AutoMapperProfile.cs
│
├── appsettings.json
└── Program.cs
```

---

## 📸 Görseller

*(Swagger ekran görüntüsü, veritabanı şeması veya Postman test sonuçları buraya eklenebilir.)*

---

## 🧱 Lisans

**MIT Lisansı © 2025** — [muminemuroglu](https://github.com/muminemuroglu/ActivityLogApi)

---

> ✨ Bu proje eğitim amaçlı geliştirilmiştir.  
> ASP.NET Core ve REST API mimarisi üzerine tam katmanlı örnek bir uygulamadır.
