# 🦁 Lamassu Book Store – E-Commerce Platform

> Ett komplett e-commerce-system byggt med **ASP.NET Core MVC**, **Razor Pages**, **Identity**, **Stripe-betalning**, och en **adminpanel** för full kontroll över böcker, användare och ordrar.

---

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-blue?logo=dotnet&logoColor=white" alt=".NET Badge"/>
  <img src="https://img.shields.io/badge/ASP.NET_Core-MVC-purple?logo=dotnet&logoColor=white" alt="ASP.NET Badge"/>
  <img src="https://img.shields.io/badge/Razor_Pages-Enabled-6C63FF?logo=razorpay&logoColor=white" alt="Razor Pages Badge"/>
  <img src="https://img.shields.io/badge/Bootstrap-5.3-7952B3?logo=bootstrap&logoColor=white" alt="Bootstrap Badge"/>
  <img src="https://img.shields.io/badge/Stripe_Payments-Integrated-008CDD?logo=stripe&logoColor=white" alt="Stripe Badge"/>
  <img src="https://img.shields.io/badge/jQuery-3.7-0769AD?logo=jquery&logoColor=white" alt="jQuery Badge"/>
</p>

---

## 📖 Projektöversikt

**Lamassu Book Store** är en **e-commerce-plattform för böcker**, utvecklad som ett **examensarbete**.  
Applikationen erbjuder både en **kundvy** och en **adminpanel**.  
Kunder kan **bläddra bland böcker, söka, lägga till i varukorg, betala med Stripe** och följa orderstatus.  
Administratörer kan **hantera böcker, kategorier, användare, roller, ordrar, samt blockera användare**.

Fokusområden:
- 🧩 Fullstack-utveckling i .NET-ekosystemet  
- 🔒 Säkerhet med Identity & rollbaserad auktorisering  
- 💳 Stripe-integration för säkra betalningar  
- 📚 Dynamiska Razor Pages med jQuery-interaktivitet  

---

## ⚙️ Funktioner

✅ CRUD-operationer för böcker och kategorier  
✅ Autentisering & auktorisering med **ASP.NET Core Identity**  
✅ **Assign / Remove Roles** direkt i adminpanelen  
✅ **Block / Unblock users** för förbättrad säkerhet  
✅ **Sökfunktion** för att hitta böcker efter titel, kategori eller författare  
✅ Hantering av **ordrar** (status, betalning, leverans)  
✅ **Stripe-betalningar** med säker checkout  
✅ Responsiv design med **Bootstrap 5**  
✅ Interaktiva komponenter med **jQuery och JavaScript**  
✅ Razor Pages för dynamiska vyer  
✅ Notiser och meddelanden (toasts, modals)  
✅ Session-baserad shopping cart  

---
<img width="400" height="400" alt="lamassu-books-home" src="https://github.com/user-attachments/assets/7b4150e5-d4da-4072-b2f4-af0a1703622c" />
<img width="400" height="400" alt="Lamassu-books-orders" src="https://github.com/user-attachments/assets/fe1b30c9-612f-4be1-9e9f-ebb866055d2e" />
<img width="400" height="400" alt="lamassu-books-product" src="https://github.com/user-attachments/assets/32b873b3-bb0a-480f-a00a-f502d7cc515f" />


## 🧱 Teknologier och verktyg

### 🔧 Backend
| Funktion | Teknologi |
|-----------|------------|
| 🧱 **Ramverk** | [ASP.NET Core MVC](https://learn.microsoft.com/aspnet/core/mvc) |
| 💾 **ORM** | [Entity Framework Core](https://learn.microsoft.com/ef/core) |
| 🗃️ **Databas** | SQL Server / LocalDB |
| 🔐 **Autentisering & Roller** | [ASP.NET Identity](https://learn.microsoft.com/aspnet/core/security/authentication/identity) |
| 💳 **Betalning** | [Stripe .NET SDK](https://stripe.com/docs/api/dotnet) |
| 🧩 **DP (Dependency Injection)** | Inbyggt i .NET Core |
| ⚙️ **Arkitektur** | Flernivåstruktur: Controllers → Services → Repositories → Models |

---

### 💻 Frontend
| Funktion | Teknologi |
|-----------|------------|
| 🧠 **Templating** | Razor Pages (CSHTML) |
| 🎨 **Stil** | [Bootstrap 5](https://getbootstrap.com/) + anpassad CSS |
| ⚙️ **Interaktivitet** | [JavaScript (ES6)](https://developer.mozilla.org/en-US/docs/Web/JavaScript) + [jQuery](https://jquery.com/) |
| 🧱 **Markup** | HTML5 |
| 🔍 **Sökfunktionalitet** | jQuery + server-side filter |
| 🔔 **Notiser & Modaler** | Bootstrap Toasts / Modals |

---

## 🧭 Funktionalitet i detalj

### 👥 **Användarroller**
| Roll | Behörigheter |
|------|---------------|
| 🧑‍💻 **Admin** | Full kontroll över böcker, kategorier, användare, roller, ordrar, betalningar |
| 👩‍💼 **Employee** | Kan hantera ordrar och uppdatera leveransstatus |
| 📚 **Customer** | Kan bläddra, handla, betala, och följa leveransstatus |

### 🔐 **Användarhantering**
- Lägg till eller ta bort roller (Assign / Remove Role)  
- Blockera eller återaktivera användare  
- Hantera användarinformation via adminpanelen  

### 🛍️ **E-commerce-flöde**
