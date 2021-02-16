using Entities.Concrete;
using System;
using System.Collections.Generic;
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
       
    }
}
