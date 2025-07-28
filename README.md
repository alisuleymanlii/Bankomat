# 💳 Sadə Bank Hesabı İdarəetmə Proqramı / Simple Bank Account Management Program

Bu **C# konsol tətbiqi** istifadəçiyə qeydiyyat, giriş və balans idarəetməsi (pul əlavə etmək, çıxartmaq, balansı göstərmək) imkanları verir.

---

## 🔧 Xüsusiyyətlər / Features

- ✅ İstifadəçi qeydiyyatı (ad və yaş) / User registration (name and age)  
- ✅ Giriş sistemi (3 cəhd imkanı) / Login system (3 attempts)  
- ✅ Balansı göstərmək / Show balance  
- ✅ Balansa pul əlavə etmək / Deposit money  
- ✅ Balansdan pul çıxarmaq / Withdraw money  
- ✅ Proqramdan çıxmaq / Exit program

---

## 📌 İstifadə Qaydası / Usage

1. Proqram başladıqda istifadəçidən ad və yaş (şifrə kimi) daxil etməsi tələb olunur (qeydiyyat).  
2. Sonra istifadəçi qeydiyyat məlumatları ilə 3 cəhd daxil olmaqla giriş edə bilər.  
3. Giriş uğurlu olarsa, menyu görünür:  
   - 1: Balansı göstər  
   - 2: Balansa pul əlavə et  
   - 3: Balansdan pul çıxar  
   - 4: Proqramdan çıx  
4. Əlavə və çıxarış əməliyyatlarında balans yenilənir və göstərilir.  
5. Yanlış girişdə qalan cəhd sayı göstərilir və 3 cəhd bitdikdə proqram dayanır.

1. At startup, user inputs name and age (used as password) for registration.  
2. User has 3 attempts to login using the registered credentials.  
3. On successful login, menu is displayed:  
   - 1: Show balance  
   - 2: Deposit money  
   - 3: Withdraw money  
   - 4: Exit program  
4. Deposit and withdrawal update and show the balance.  
5. On failed login, remaining attempts are shown; after 3 failures program exits.

---

## ⚠️ Qeyd / Notes

- Yaş məlumatı şifrə kimi istifadə olunur.  
- Balans integer tipində idarə olunur.  
- Pul çıxarışında balansdan çox məbləğ çıxarmağa icazə verilmir.  
- İstifadəçi giriş məlumatlarını unudarsa, proqram yenidən başladılmalıdır.

- Age is used as password.  
- Balance is managed as an integer.  
- Withdrawal cannot exceed the current balance.  
- If user forgets login info, program must be restarted.

---

## 👨‍💻 Müəllif / Author

**Ad:** Əli 
**Dil:** C#  
**Tətbiq Tipi:** Konsol tətbiqi  

**Name:** Ali  
**Language:** C#  
**Application Type:** Console application  
