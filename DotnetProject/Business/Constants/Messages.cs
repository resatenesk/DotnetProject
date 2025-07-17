using Core.Entities.Concrete;
using Microsoft.Identity.Client;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAddedMessage = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExist = "Bu ürün ismi zaten var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = " Kullanıcı bulunamadı";
        public static string PasswordError = "Parola yanlış";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Giriş tokeni oluşturuldu";
    }
}