# 🧠 Developer Mentorship Platform — Software Consulting Simulation

<br>

[![Report Bug](https://img.shields.io/badge/🐛_Report_Bug-red?style=for-the-badge)](../../issues/new?labels=bug)
[![Request Feature](https://img.shields.io/badge/✨_Request_Feature-blue?style=for-the-badge)](../../issues/new?labels=enhancement)

<br>

## 📌 Project Overview

**Developer Mentorship Platform** is a simulation of a company that provides **software consulting and mentorship services** through an online platform.  
Mentors can register on the site to offer guidance, while users can reach out for **software development support** and **career mentoring**.  

<br>

## ✨ Features

- 👤 **User Management** — Membership system for both mentors and mentees  
- 💬 **Software Consulting** — Users can connect with mentors for development help and career advice  
- 🧱 **Layered Architecture** — Built with n-tier architecture for scalability and maintainability  
- 🗄️ **Database Design** — Well-structured relational design ensuring consistency and performance  
- 🧠 **Repository Pattern + DI** — Repository abstraction and dependency injection for clean, testable code

<br>


## 🖼️ Screenshots
## 🖼️ Screenshots
Shown below in order:  
**1. Landing 1** · **2. Landing 2** · **3. Services**<br>
**4. Blog** · **5. Pricing & Footer** · **6. Contact**

<p align="center">
  <img src="./docs/screenshots/landing-1.png" width="32%">
  <img src="./docs/screenshots/landing-2.png" width="32%">
  <img src="./docs/screenshots/services.png" width="32%">
</p>

<p align="center">
  <img src="./docs/screenshots/blog.png" width="32%">
  <img src="./docs/screenshots/pricing-and-footer.png" width="32%">
  <img src="./docs/screenshots/contact.png" width="32%">
</p>

<br>

## 🧰 Tech Stack

<p>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C# Badge" height="32" />
  <img src="https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt="ASP.NET Core Badge" height="32" />
  <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" alt="HTML5 Badge" height="32" />
  <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white" alt="CSS3 Badge" height="32" />
  <img src="https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black" alt="JavaScript Badge" height="32" />
  <img src="https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="SQL Server Badge" height="32" />
</p>


<br>

## 📥 Installation

### Prerequisites
- .NET SDK 7.0+  
- Microsoft SQL Server

### Setup
```bash
git clone [repository-url]
cd developer-mentorship-platform

dotnet restore
dotnet ef database update   # Apply migrations
dotnet run
```

Then open the application in your browser.  
Mentors and users can register, and consulting features can be tested through the UI and API.

<br>

## 📜 License

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

This project is licensed under the terms described in the [LICENSE](./LICENSE) file.

---

© 2025 Yusuf Okan Sirkeci — [Hereetria](https://github.com/Hereetria)
