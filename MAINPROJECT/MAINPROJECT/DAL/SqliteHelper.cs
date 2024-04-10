using System;
using System.Collections.Generic;
using System.Data.SQLite;
namespace MAINPROJECT.DAL
{
    internal class SqliteHelper
    {
        internal static List<User> GetUsers()
        {
            try
            {
                using (var connection = new SQLiteConnection($"DataSource = C:/UPC/db; Version = 3;DateTimeFormat = CurrentCulture;"))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(@"SELECT id , Вид документа , Статус_документа , Подтверждение_утраты , Подтверждение_обмена , 
                Подтверждение_уничтожения , Серия_документа , Номер_документа , Дата_выдачи_документа ,  
                Дата_просрочки_документа, Регистрационный_номер , Дополнительная_профессиональная_программа ,  
                Наименование_дополнительной_профессиональной_программы ,  
                Наименование_области_профессиональной_деятельности , Укрупненные_группы_специальностей ,  
                Наименование_квалификации_профессии_специальности , Уровень_образования_ВО_СПО ,  
                Фамилия_указанная_в_дипломе_о_ВО_или_СПО , Серия_документа_о_ВО_СПО , Номер_документа_о_ВО_СПО ,  
                Год_начала_обучения , Год_окончания_обучения ,  
                Срок_обучения_часов , Наименование_организации, Фамилия_получателя , Имя_получателя ,  
                Отчество_получателя , Дата_рождения_получателя , Пол_получателя , СНИЛС , Форма_обучения ,  
                Источник_финансирования_обучения , Форма_получения_образования_на_момент_прекращения_образовательных_отношений ,  
                Гражданство_получателя_код_страны_по_ОКСМ ,Наименование_документа_об_образовании , Серия_оригинала ,  
                Номер_оригинала , Регистрационный_N_оригинала , Дата_выдачи_оригинала , Фамилия_получателя_оригинала , 
                 Имя_получателя_оригинала , Отчество_получателя_оригинала , Номер_документа_для_изменения FROM Students", connection))
                    {
                        using(var rdr = cmd.ExecuteReader())
                        {
                            List<User> users = new List<User>();
                            while(rdr.Read())
                            {
                                users.Add(new User{
                                    ID = rdr.GetInt32(0),
                                    Vid_dokumenta = rdr.GetString(1),
                                    Status_dokumenta = rdr.GetString(2),
                                    Podtverzhdenie_utraty = rdr.GetString(3),
                                    Podtverzhdenie_obmena = rdr.GetString(4),
                                    Podtverzhdenie_unichtozheniya = rdr.GetString(5),
                                    Seriya_dokumenta = rdr.GetString(6),
                                    Nomer_dokumenta = rdr.GetString(7),
                                    Data_vydachi_dokumenta = rdr.GetString(8),
                                    Data_prosrochki_dokumenta = rdr.GetDateTime(9),
                                    Registratsionnyy_nomer = rdr.GetString(10),
                                    Dopolnitelnaya_professionalnaya_programma = rdr.GetString(11),
                                    Naimenovanie_dopolnitelnoy_professionalnoy_programmy = rdr.GetString(12),
                                    Naimenovanie_oblasti_professionalnoy_deyatelnosti = rdr.GetString(13),
                                    Ukrupnennye_gruppy_spetsialnostey = rdr.GetString(14),
                                    Naimenovanie_kvalifikatsii_professii_spetsialnosti = rdr.GetString(15),
                                    Uroven_obrazovaniya_VO_SPO = rdr.GetString(16),
                                    Familiya_ukazannaya_v_diplome_o_VO_ili_SPO = rdr.GetString(17),
                                    Seriya_dokumenta_o_VO_SPO = rdr.GetString(18),
                                    Nomer_dokumenta_o_VO_SPO = rdr.GetString(19),
                                    God_nachala_obucheniya = rdr.GetString(20),
                                    God_okonchaniya_obucheniya = rdr.GetString(21),
                                    Srok_obucheniya_chasov = rdr.GetString(22),
                                    Naimenovanie_organizacii = rdr.GetString(23),
                                    Familiya_poluchatelya = rdr.GetString(24),
                                    Imya_poluchatelya = rdr.GetString(25),
                                    Otchestvo_poluchatelya = rdr.GetString(26),
                                    Data_rozhdeniya_poluchatelya = rdr.GetString(27),
                                    Pol_poluchatelya = rdr.GetString(28),
                                    SNILS = rdr.GetString(29),
                                    Forma_obucheniya = rdr.GetString(30),
                                    Istochnik_finansirovaniya_obucheniya = rdr.GetString(31),
                                    Forma_polucheniya_obrazovaniya_na_moment_prekrashcheniya_obrazovatelnykh_otnosheniy = rdr.GetString(32),
                                    Grazhdanstvo_poluchatelya_kod_strany_po_OKSM = rdr.GetString(33),
                                    Naimenovanie_dokumenta_ob_obrazovanii = rdr.GetString(34),
                                    Seriya_originala = rdr.GetString(35),
                                    Nomer_originala = rdr.GetString(36),
                                    Registratsionnyy_N_originala = rdr.GetString(37),
                                    Data_vydachi_originala = rdr.GetString(38),
                                    Familiya_poluchatelya_originala = rdr.GetString(39),
                                    Imya_poluchatelya_originala = rdr.GetString(40),
                                    Otchestvo_poluchatelya_originala = rdr.GetString(41),
                                    Nomer_dokumenta_dlya_izmeneniya = rdr.GetString(42)
                                });
                            }

                            return users;
                        }
                    }                    
                } 
            }
            catch (Exception ex ){ Console.WriteLine(ex.Message);  }
            return null;
        }
    }
}
