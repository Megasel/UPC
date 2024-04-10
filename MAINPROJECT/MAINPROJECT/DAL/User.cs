using System;
using System.ComponentModel;
using System.Data.SQLite;

namespace MAINPROJECT.DAL
{
    internal class User
    {
        [DisplayName("ID")]
        public int ID { get; internal set; }
        [DisplayName("Вид документа")]
        public string Vid_dokumenta { get; internal set; }
        [DisplayName("Статус документа")]
        public string Status_dokumenta { get; internal set; }
        [DisplayName("Подтверждение утраты")]
        public string Podtverzhdenie_utraty { get; internal set; }
        [DisplayName("Подтверждение обмена")]
        public string Podtverzhdenie_obmena { get; internal set; }
        [DisplayName("Подтверждение уничтожения")]
        public string Podtverzhdenie_unichtozheniya { get; internal set; }
        [DisplayName("Серия документа")]
        public string Seriya_dokumenta { get; internal set; }
        [DisplayName("Номер документа")]
        public string Nomer_dokumenta { get; internal set; }
        [DisplayName("Дата выдачи документа")]
        public string Data_vydachi_dokumenta { get ; internal set; }
        [DisplayName("Регистрационный номер")]
        public string Registratsionnyy_nomer { get; internal set; }
        [DisplayName("Дополнительная профессиональная программа")]
        public string Dopolnitelnaya_professionalnaya_programma { get; internal set; }
        [DisplayName("Наименование дополнительной профессиональной программы")]
        public string Naimenovanie_dopolnitelnoy_professionalnoy_programmy { get; internal set; }
        [DisplayName("Наименование области профессиональной деятельности")]
        public string Naimenovanie_oblasti_professionalnoy_deyatelnosti { get; internal set; }
        [DisplayName("Укрупненные группы специальностей")]
        public string Ukrupnennye_gruppy_spetsialnostey { get; internal set; }
        [DisplayName("Наименование квалификации профессии специальности")]
        public string Naimenovanie_kvalifikatsii_professii_spetsialnosti { get; internal set; }
        [DisplayName("Уровень образования ВО/СПО")]
        public string Uroven_obrazovaniya_VO_SPO { get; internal set; }
        [DisplayName("Фамилия указанная в дипломе о ВО/СПО")]
        public string Familiya_ukazannaya_v_diplome_o_VO_ili_SPO { get; internal set; }
        [DisplayName("Серия документа о ВО/СПО")]
        public string Seriya_dokumenta_o_VO_SPO { get; internal set; }
        [DisplayName("Номер документа о ВО/СПО")]
        public string Nomer_dokumenta_o_VO_SPO { get; internal set; }
        [DisplayName("Год начала обучения")]
        public string God_nachala_obucheniya { get; internal set; }
        [DisplayName("Год оконачания обучения")]
        public string God_okonchaniya_obucheniya { get; internal set; }
        [DisplayName("Срок обучения (часов)")]
        public string Srok_obucheniya_chasov { get; internal set; }
        [DisplayName("Фамилия получателя")]
        public string Familiya_poluchatelya { get; internal set; }
        [DisplayName("Имя получателя")]
        public string Imya_poluchatelya { get; internal set; }
        [DisplayName("Отчество получателя")]
        public string Otchestvo_poluchatelya { get; internal set; }
        [DisplayName("Дата рождения получателя")]
        public string Data_rozhdeniya_poluchatelya { get; internal set; }
        [DisplayName("Пол получателя")]
        public string Pol_poluchatelya { get; internal set; }
        [DisplayName("СНИЛС")]
        public string SNILS { get; internal set; }
        [DisplayName("Форма обучения")]
        public string Forma_obucheniya { get; internal set; }
        [DisplayName("Источник финансирования обучения")]
        public string Istochnik_finansirovaniya_obucheniya { get; internal set; }
        [DisplayName("Форма получения образования на момент прекращения образовательных отношений")]
        public string Forma_polucheniya_obrazovaniya_na_moment_prekrashcheniya_obrazovatelnykh_otnosheniy { get; internal set; }
        [DisplayName("Гражданство получаетеля (код страны по ОКСМ)")]
        public string Grazhdanstvo_poluchatelya_kod_strany_po_OKSM { get; internal set; }
        [DisplayName("Наименование документа об образовании")]
        public string Naimenovanie_dokumenta_ob_obrazovanii { get; internal set; }
        [DisplayName("Серия оригинала")]
        public string Seriya_originala { get; internal set; }
        [DisplayName("Номер оригинала")]
        public string Nomer_originala { get; internal set; }
        [DisplayName("Регистрационный номер оригинала")]
        public string Registratsionnyy_N_originala { get; internal set; }
        [DisplayName("Дата выдачи оригинала")]
        public string Data_vydachi_originala { get; internal set; }
        [DisplayName("Фамилия получателя оригинала")]
        public string Familiya_poluchatelya_originala { get; internal set; }
        [DisplayName("Имя получателя оригинала")]
        public string Imya_poluchatelya_originala { get; internal set; }
        [DisplayName("Отчество получателя оригинала")]
        public string Otchestvo_poluchatelya_originala { get; internal set; }
        [DisplayName("Номер документа для изменения")]
        public string Nomer_dokumenta_dlya_izmeneniya { get; internal set; }
        [DisplayName("Наименование организации")]
        public string Naimenovanie_organizacii { get; internal set; }
        public DateTime Data_prosrochki_dokumenta { get; internal set; }
    }
}