﻿Public Class Form_main_window
    Private web_client As System.Net.WebClient = New System.Net.WebClient
    Private divar_api_search_url As String = "http://api.divar.ir/v8/web-search/"
    Private category As String = ""
    Private city As String = ""
    Private search_string As String = "&q="
    Private current_page_number As UInt16

    REM# on click about
    Private Sub ToolStripMenuItem_about_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_about.Click
        AboutBox_divarchin.Show()
    End Sub

    REM# on click Button_refresh
    Private Sub Button_refresh_Click(sender As Object, e As EventArgs) Handles Button_refresh.Click
        REM# prevent crash if nothing has been set
        If category = "" Or city = "" Then
            Exit Sub
        End If

        Dim json_from_site As String = ""
        Dim parsed_json_from_site As Newtonsoft.Json.Linq.JObject
        Dim number_of_posts As Byte = 0
        Dim item_title As String
        Dim item_desription As String

        REM# download page and pars it
        json_from_site = web_client.DownloadString(divar_api_search_url + city + category + "?page=" + System.Convert.ToString(current_page_number) + search_string)
        parsed_json_from_site = Newtonsoft.Json.Linq.JObject.Parse(json_from_site)

        number_of_posts = parsed_json_from_site.Item("web_widgets").Item("post_list").Count

        REM# clear DataGridView_result
        DataGridView_result.Rows.Clear()

        REM# populate ListView_result
        For i = 0 To number_of_posts - 1
            item_title = parsed_json_from_site.Item("web_widgets").Item("post_list").Item(i).Item("data").Item("title").ToString
            item_desription = parsed_json_from_site.Item("web_widgets").Item("post_list").Item(i).Item("data").Item("description").ToString
            DataGridView_result.Rows.Insert(i, {item_title, item_desription})
        Next
    End Sub

    REM# on click Button_backward
    Private Sub Button_backward_Click(sender As Object, e As EventArgs) Handles Button_backward.Click
        REM# prevent crash if no city has been set
        REM# prevent bad result if current_page_number = 1
        If city = "" Or current_page_number = 1 Then
            Exit Sub
        End If

        Dim json_from_site As String = ""
        Dim parsed_json_from_site As Newtonsoft.Json.Linq.JObject
        Dim number_of_posts As Byte = 0
        Dim item_title As String
        Dim item_desription As String

        REM# go to the previous page
        current_page_number -= 1

        REM# download page and pars it
        json_from_site = web_client.DownloadString(divar_api_search_url + city + category + "?page=" + System.Convert.ToString(current_page_number) + search_string)
        parsed_json_from_site = Newtonsoft.Json.Linq.JObject.Parse(json_from_site)

        number_of_posts = parsed_json_from_site.Item("web_widgets").Item("post_list").Count

        REM# clear DataGridView_result
        DataGridView_result.Rows.Clear()

        REM# populate ListView_result
        For i = 0 To number_of_posts - 1
            item_title = parsed_json_from_site.Item("web_widgets").Item("post_list").Item(i).Item("data").Item("title").ToString
            item_desription = parsed_json_from_site.Item("web_widgets").Item("post_list").Item(i).Item("data").Item("description").ToString
            DataGridView_result.Rows.Insert(i, {item_title, item_desription})
        Next
    End Sub

    REM# on click Button_forward
    Private Sub Button_forward_Click(sender As Object, e As EventArgs) Handles Button_forward.Click
        REM# prevent crash if no city has been set
        If city = "" Then
            Exit Sub
        End If

        Dim json_from_site As String = ""
        Dim parsed_json_from_site As Newtonsoft.Json.Linq.JObject
        Dim number_of_posts As Byte = 0
        Dim item_title As String
        Dim item_desription As String

        REM# go to the next page
        current_page_number += 1

        REM# download page and pars it
        json_from_site = web_client.DownloadString(divar_api_search_url + city + category + "?page=" + System.Convert.ToString(current_page_number) + search_string)
        parsed_json_from_site = Newtonsoft.Json.Linq.JObject.Parse(json_from_site)

        number_of_posts = parsed_json_from_site.Item("web_widgets").Item("post_list").Count

        REM# clear DataGridView_result
        DataGridView_result.Rows.Clear()

        REM# populate ListView_result
        For i = 0 To number_of_posts - 1
            item_title = parsed_json_from_site.Item("web_widgets").Item("post_list").Item(i).Item("data").Item("title").ToString
            item_desription = parsed_json_from_site.Item("web_widgets").Item("post_list").Item(i).Item("data").Item("description").ToString
            DataGridView_result.Rows.Insert(i, {item_title, item_desription})
        Next
    End Sub

    REM# on click button_search
    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        Dim json_from_site As String = ""
        Dim parsed_json_from_site As Newtonsoft.Json.Linq.JObject
        Dim number_of_posts As Byte = 0
        Dim item_title As String
        Dim item_desription As String
        Dim i As Integer REM# loop counter. has to be Integer!

        REM# retrieve selected category
        category = TreeView_categories.SelectedNode.Name

        REM# retrieve selected city
        city = retrieve_selected_city()

        REM# retrieve search string
        search_string += TextBox_search_exp.Text

        REM# if TextBox_search_exp is empty then erase search_string
        If search_string = "&q=" Then
            search_string = ""
        End If

        REM# download page and pars it
        json_from_site = web_client.DownloadString(divar_api_search_url + city + category + "?page=1" + search_string)
        parsed_json_from_site = Newtonsoft.Json.Linq.JObject.Parse(json_from_site)

        current_page_number = 1

        number_of_posts = parsed_json_from_site.Item("web_widgets").Item("post_list").Count

        REM# clear DataGridView_result
        DataGridView_result.Rows.Clear()

        REM# populate ListView_result
        For i = 0 To number_of_posts - 1
            item_title = parsed_json_from_site.Item("web_widgets").Item("post_list").Item(i).Item("data").Item("title").ToString
            item_desription = parsed_json_from_site.Item("web_widgets").Item("post_list").Item(i).Item("data").Item("description").ToString
            DataGridView_result.Rows.Insert(i, {item_title, item_desription})
        Next
    End Sub

    Private Sub Form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM# choose default value for selected city at start
        ComboBox_city.SelectedIndex = 79 REM# default city = tehran

        REM# choose default category which is all ads
        TreeView_categories.SelectedNode = TreeView_categories.TopNode

        REM# set DataGridView_result font
        DataGridView_result.DefaultCellStyle.Font = New Font("Tahoma", 12)
    End Sub

    Private Function retrieve_selected_city() As String
        Dim city As String = ""

        Select Case ComboBox_city.Text
            REM# شهرهای پربازدید
            Case "تهران"
                city = "tehran"
            Case "مشهد"
                city = "mashhad"
            Case "کرج"
                city = "karaj"
            Case "شیراز"
                city = "shiraz"
            Case "اصفهان"
                city = "isfahan"
            Case "اهواز"
                city = "ahvaz"
            Case "تبریز"
                city = "tabriz"
            Case "کرمانشاه"
                city = "kermanshah"
            Case "قم"
                city = "qom"
            Case "رشت"
                city = "rasht"

            REM# آ
            Case "آبادان"
                city = "abadan"
            Case "آباده"
                city = "abadeh"
            Case "آبدانان"
                city = "abdanan"
            Case "آبسرد"
                city = "absard"
            Case "آبعلی"
                city = "abali"
            Case "آذرشهر"
                city = "azarshahr"
            Case "آران و بیدگل"
                city = "aran-va-bidgol"
            Case "آزادشهر"
                city = "azadshahr-golestan"
            Case "آسارا"
                city = "asara"
            Case "آستارا"
                city = "astara"
            Case "آستانه اشرفیه"
                city = "astaneh-ashrafiyeh"
            Case "آشخانه"
                city = "ashkhaneh"
            Case "آق قلا"
                city = "aq-qala"
            Case "آمل"
                city = "amol"

            REM# ا
            Case "ابریشم"
                city = "abrisham-isfahan"

            REM# ب
            Case "بابل"
                city = "babol"
            Case "بابلسر"
                city = "babolsar"
            Case "باقرشهر"
                city = "baghershahr"
            Case "بانه"
                city = "baneh"
            Case "بجنورد"
                city = "bojnurd"
            Case "برازجان"
                city = "borazjan"
            Case "بردسکن"
                city = "bardaskan"
            Case "بروجرد"
                city = "borujerd"
            Case "بروجن"
                city = "boroujen"

            REM# پ
            Case "پارس‌آباد"
                city = "parsabad"
            Case "پل سفید"
                city = "polsefid"
            Case "پیرانشهر"
                city = "piranshahr"
            Case "پیشوا"
                city = "pishva"

            REM# ت
            Case "تاکستان"
                city = "takestan"
            Case "تالش"
                city = "talesh"
            Case "تایباد"
                city = "taybad"
            Case "تربت جام"
                city = "torbat-jam"

            REM# ج
            Case "جوادآباد"
                city = "javadabad"

            REM# چ
            Case "چابکسر"
                city = "chaboksar"

            REM# ح
            Case "حمیدیا"
                city = "hamidia"

            REM# خ
            Case "خرم‌آباد"
                city = "khorramabad"
            Case "خرمدره"
                city = "khorramdarreh"
            Case "خرمشهر"
                city = "khorramshahr"
            Case "خشکبیجار"
                city = "khoshkbijar"
            Case "خلخال"
                city = "khalkhal"
            Case "خمین"
                city = "khomein"
            Case "خواف"
                city = "khaf"
            Case "خوانسار"
                city = "khansar"
            Case "خوی"
                city = "khoy"

            REM# د
            Case "داراب"
                city = "darab"
            Case "داران"
                city = "daran"
            Case "دامغان"
                city = "damghan"
            Case "دزفول"
                city = "dezful"
            Case "دماوند"
                city = "damavand"
            Case "درود"
                city = "dorud"
            Case "دوگنبدان"
                city = "dogonbadan"
            Case "دهدشت"
                city = "dehdasht"
            Case "دهلران"
                city = "dehloran"

            REM# ر
            Case "رامسر"
                city = "ramsar"
            Case "رامهرمز"
                city = "ramhormoz"
            Case "رضوانشهر"
                city = "rezvanshahr"
            Case "رفسنجان"
                city = "rafsanjan"
            Case "رودسر"
                city = "rudsar"
            Case "رویان"
                city = "royan"

            REM# ز
            Case "زابل"
                city = "zabol"
            Case "زاهدان"
                city = "zahedan"
            Case "زرند"
                city = "zarand"
            Case "زنجان"
                city = "zanjan"
            Case "زیباکنار"
                city = "zibakenar"

            REM# س
            Case "ساری"
                city = "sari"
            Case "ساوه"
                city = "saveh"
            Case "سبزوار"
                city = "sabzevar"
            Case "سراب"
                city = "sarab"
            Case "سراوان-سیستان و بلوچستان"
                city = "saravan"
            Case "سرپل ذهاب"
                city = "sarpol-zahab"
            Case "سرخرود"
                city = "sorkhrood"
            Case "سردشت"
                city = "sardasht"
            Case "سقز"
                city = "saqqez"
            Case "سلماس"
                city = "salmas"
            Case "سلمان‌شهر"
                city = "salman-shahr"
            Case "سمنان"
                city = "semnan"
            Case "سمیرم"
                city = "semirom"
            Case "سنقر"
                city = "sonqor"
            Case "سنندج"
                city = "sanandaj"
            Case "سوسنگرد"
                city = "susangerd"
            Case "سهند"
                city = "sahand"
            Case "سیاهکل"
                city = "siahkal"
            Case "سیرجان"
                city = "sirjan"

            REM# ش
            Case "شاهدشهر"
                city = "shahedshahr"
            Case "شاهرود"
                city = "shahroud"
            Case "شاهین دژ"
                city = "shahin-dej"
            Case "شمشک"
                city = "shemshak"
            Case "شوش"
                city = "shush"
            Case "شوشتر"
                city = "shooshtar"
            Case "شهرکرد"
                city = "shahrekord"
            Case "شیروان"
                city = "shirvan"

            REM# ص
            Case "صباشهر"
                city = "sabashahr"
            Case "صدرا-فارس"
                city = "sadra"
            Case "صفادشت"
                city = "safadasht-industrial-city"
            Case "صومعه‌سرا"
                city = "someh-sara"

            REM# ط
            Case "طالقان"
                city = "taleqan"
            Case "طبس"
                city = "tabas"

            REM# ع
            Case "عباس‌آباد"
                city = "abbasabad-mazandaran"
            Case "علی‌آباد کتول"
                city = "aliabad-katul"

            REM# ف
            Case "فرخ‌شهر"
                city = "farrokhshahr"
            Case "فردوس"
                city = "ferdows"
            Case "فردوسیه"
                city = "ferdosiye"
            Case "فریدون‌کنار"
                city = "fereydunkenar"
            Case "فلاورجان"
                city = "falavarjan"
            Case "فومن"
                city = "fuman"
            Case "فیروزآباد"
                city = "firuzabad"

            REM# ق
            Case "قائم‌شهر"
                city = "qaemshahr"
            Case "قاسم‌آباد (خواف)"
                city = "qasemabad-khaf"
            Case "قاين"
                city = "ghayen"
            Case "قروه"
                city = "qorveh"
            Case "قزوین"
                city = "qazvin"
            Case "قشم"
                city = "qeshm"
            Case "قیدار"
                city = "qeydar"

            REM# ک
            Case "کاشان"
                city = "kashan"
            Case "کردکوی"
                city = "kordkuy"
            Case "کرمان"
                city = "kerman"
            Case "کرمانشاه"
                city = "kermanshah"

            REM# گ
            Case "گرگان"
                city = "gorgan"
            Case "گرمدره"
                city = "garmdareh"
            Case "گرمسار"
                city = "garmsar"
            Case "گلپایگان"
                city = "golpayegan"
            Case "گلستان"
                city = "golestan-baharestan"
            Case "گمیشان"
                city = "gomishan"
            Case "گناباد"
                city = "gonabad"
            Case "گنبد کاووس"
                city = "gonbad-kavus"

            REM# ل
            Case "لار"
                city = "lar"
            Case "لامرد"
                city = "lamerd"
            Case "لاهیجان"
                city = "lahijan"
            Case "لردگان"
                city = "lordegan"
            Case "لشت نشا"
                city = "lashtenesha"
            Case "لنگرود"
                city = "langarud"

            REM# م
            Case "ماسال"
                city = "masal"
            Case "ماکو"
                city = "maku"
            Case "محلات"
                city = "mahalat"

            REM# ن
            Case "نجف‌آباد"
                city = "najafabad"
            Case "نسیم‌شهر"
                city = "nasimshahr"
            Case "نظرآباد"
                city = "nazarabad"
            Case "نقده"
                city = "naqadeh"
            Case "نکا"
                city = "neka"
            Case "نور"
                city = "nur"
            Case "نورآباد"
                city = "nurabad"
            Case "نوشهر"
                city = "nowshahr"
            Case "نهاوند"
                city = "nahavand"
            Case "نی‌ریز"
                city = "neyriz"
            Case "نیشابور"
                city = "neyshabur"

            REM# و
            Case "وحیدیه"
                city = "vahidieh"

            REM# ه
            Case "همدان"
                city = "hamedan"

            REM# ی
            Case "یاسوج"
                city = "yasuj"
            Case "یزد"
                city = "yazd"
        End Select

        city += "/" REM# URL related

        Return city
    End Function
End Class