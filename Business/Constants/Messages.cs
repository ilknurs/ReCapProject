using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string SuccessMessage = "İşlem başarıyla gerçekleşti.";
        public static string SuccessDataMessage= "İşlem başarıyla gerçekleşti.";
        public static string ErrorMessage ="İşlem başarısız oldu.";
        public static string ErrorDataMessage = "İşlem başarısız oldu";
        public static string RentalAddedError= "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalDeleted = "Kiralama Bilgisi Silindi.";
        public static string RentalUpdated = "Kiralama Bilgisi Güncellendi.";
        public static string CarNotFound = "Araba resmi bulunamadı.";
        public static string CarImageListed = "Araba resmi listelendi.";
        public static string CarImageAdded ="Araba resmi eklendi.";
        public static string ImageCouldNotBeAdded ="Araba resmi eklenemedi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string AuthorizationDenied ="Yetkiniz yok.";
        public static string UserNotFound ="Kullanıcı bulunamadı.";
        public static string PasswordError ="Hatalı şifre girdiniz.";
        public static string SuccessfulLogin ="Sisteme giriş başarılı.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string UserAlreadyExists ="Böyle bir kullanıcı zaten mevcut.";
        public static string AccessTokenCreated ="Access Token başarıyla oluşturuldu.";
    }
}
