<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_main_window
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("همهٔ آگهی‌ها", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آپارتمان")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("خانه و ویلا")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("زمین و کلنگی")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("فروش مسکونی", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آپارتمان")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("خانه و ویلا")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اجاره مسکونی", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("دفتر کار، اتاق اداری و مطب")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مغازه و غرفه")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("صنعتی،‌ کشاورزی و تجاری")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("فروش اداری و تجاری", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("دفتر کار، اتاق اداری و مطب")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مغازه و غرفه")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("صنعتی،‌ کشاورزی و تجاری")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اجاره اداری و تجاری", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آپارتمان و سوئیت")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ویلا و باغ")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("دفتر کار و فضای آموزشی")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اجاره کوتاه مدت", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مشارکت در ساخت")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("پیش‌فروش")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("پروژه‌های ساخت و ساز", New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("املاک", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode8, TreeNode12, TreeNode16, TreeNode20, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سواری")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کلاسیک")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اجاره‌ای")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سنگین")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("خودرو", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26, TreeNode27, TreeNode28})
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("قطعات یدکی و لوازم جانبی خودرو")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("موتورسیکلت و لوازم جانبی")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("قایق و لوازم جانبی")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("وسایل نقلیه", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode29, TreeNode30, TreeNode31, TreeNode32})
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("گوشی موبایل")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تبلت")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("لوازم جانبی موبایل و تبلت")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سیم کارت")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("موبایل و تبلت", New System.Windows.Forms.TreeNode() {TreeNode34, TreeNode35, TreeNode36, TreeNode37})
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("رایانه همراه")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("رایانه رومیزی")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("قطعات و لوازم جانبی")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مودم و تجهیزات شبکه")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("پرینتر/اسکنر/کپی/فکس")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("رایانه", New System.Windows.Forms.TreeNode() {TreeNode39, TreeNode40, TreeNode41, TreeNode42, TreeNode43})
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کنسول، بازی‌ ویدئویی و آنلاین")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("فیلم و موسیقی")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("دوربین عکاسی و فیلم‌برداری")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("پخش‌کننده همراه")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سیستم صوتی خانگی")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ویدئو و پخش کننده DVD")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تلویزیون و پروژکتور")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("دوربین مداربسته")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("صوتی و تصویری", New System.Windows.Forms.TreeNode() {TreeNode46, TreeNode47, TreeNode48, TreeNode49, TreeNode50, TreeNode51, TreeNode52})
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تلفن رومیزی")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("لوازم الکترونیکی", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode44, TreeNode45, TreeNode53, TreeNode54})
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("وسایل و تزئینات خانه")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("وسایل آشپزخانه")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("نظافت و خیاطی و اتو")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تعمیرات")
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ابزار", New System.Windows.Forms.TreeNode() {TreeNode58, TreeNode59})
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سرویس بهداشتی و سونا")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سیستم گرمایشی سرمایشی و گاز")
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آشپزخانه")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("حیاط و ایوان")
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ابزار باغبانی")
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ساختمان و حیاط", New System.Windows.Forms.TreeNode() {TreeNode61, TreeNode62, TreeNode63, TreeNode64, TreeNode65})
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مربوط به خانه", 5, 5, New System.Windows.Forms.TreeNode() {TreeNode56, TreeNode57, TreeNode60, TreeNode66})
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("موتور و ماشین")
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("پذیرایی/مراسم")
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("فروش دامنه و سایت")
        Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("میزبانی و طراحی سایت")
        Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("خدمات پهنای باند اینترنت")
        Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("خدمات نرم‌افزار و سخت‌افزار کامپیوتر")
        Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تعمیرات نرم‌افزار و سخت‌افزار گوشی موبایل")
        Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("خدمات رایانه‌ای و موبایل", New System.Windows.Forms.TreeNode() {TreeNode70, TreeNode71, TreeNode72, TreeNode73, TreeNode74})
        Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مالی/حسابداری/بیمه")
        Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("حمل و نقل")
        Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("پیشه و مهارت")
        Dim TreeNode79 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آرایشگری و زیبایی")
        Dim TreeNode80 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سرگرمی")
        Dim TreeNode81 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("نظافت")
        Dim TreeNode82 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("باغبانی و درختکاری")
        Dim TreeNode83 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("زبان خارجی")
        Dim TreeNode84 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("دروس مدرسه و دانشگاه")
        Dim TreeNode85 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("نرم‌افزار")
        Dim TreeNode86 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("هنری")
        Dim TreeNode87 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ورزشی")
        Dim TreeNode88 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مشاوره تحصیلی")
        Dim TreeNode89 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آموزشی", New System.Windows.Forms.TreeNode() {TreeNode83, TreeNode84, TreeNode85, TreeNode86, TreeNode87, TreeNode88})
        Dim TreeNode90 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("خدمات", 6, 6, New System.Windows.Forms.TreeNode() {TreeNode68, TreeNode69, TreeNode75, TreeNode76, TreeNode77, TreeNode78, TreeNode79, TreeNode80, TreeNode81, TreeNode82, TreeNode89})
        Dim TreeNode91 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کیف/کفش/کمربند")
        Dim TreeNode92 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("لباس")
        Dim TreeNode93 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کیف، کفش و لباس", New System.Windows.Forms.TreeNode() {TreeNode91, TreeNode92})
        Dim TreeNode94 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ساعت")
        Dim TreeNode95 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("جواهرات")
        Dim TreeNode96 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("بدلیجات")
        Dim TreeNode97 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تزیینی", New System.Windows.Forms.TreeNode() {TreeNode94, TreeNode95, TreeNode96})
        Dim TreeNode98 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آرایشی، بهداشتی و درمانی")
        Dim TreeNode99 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کفش و لباس بچه")
        Dim TreeNode100 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اسباب بازی")
        Dim TreeNode101 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کالسکه و لوازم جانبی")
        Dim TreeNode102 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("صندلی بچه")
        Dim TreeNode103 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اسباب و اثاث بچه")
        Dim TreeNode104 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("وسایل بچه و اسباب بازی", New System.Windows.Forms.TreeNode() {TreeNode100, TreeNode101, TreeNode102, TreeNode103})
        Dim TreeNode105 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("لوازم التحریر")
        Dim TreeNode106 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("وسایل شخصی", 7, 7, New System.Windows.Forms.TreeNode() {TreeNode93, TreeNode97, TreeNode98, TreeNode99, TreeNode104, TreeNode105})
        Dim TreeNode107 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کنسرت")
        Dim TreeNode108 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تئاتر و سینما")
        Dim TreeNode109 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کارت هدیه و تخفیف")
        Dim TreeNode110 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اماکن و مسابقات ورزشی")
        Dim TreeNode111 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ورزشی")
        Dim TreeNode112 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اتوبوس، مترو و قطار")
        Dim TreeNode113 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("بلیط", New System.Windows.Forms.TreeNode() {TreeNode107, TreeNode108, TreeNode109, TreeNode110, TreeNode111, TreeNode112})
        Dim TreeNode114 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تور و چارتر")
        Dim TreeNode115 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آموزشی")
        Dim TreeNode116 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ادبی")
        Dim TreeNode117 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تاریخی")
        Dim TreeNode118 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مذهبی")
        Dim TreeNode119 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مجلات")
        Dim TreeNode120 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کتاب و مجله", New System.Windows.Forms.TreeNode() {TreeNode115, TreeNode116, TreeNode117, TreeNode118, TreeNode119})
        Dim TreeNode121 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("دوچرخه/اسکیت/اسکوتر")
        Dim TreeNode122 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("گربه")
        Dim TreeNode123 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("موش و خرگوش")
        Dim TreeNode124 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("خزنده")
        Dim TreeNode125 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("پرنده")
        Dim TreeNode126 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ماهی")
        Dim TreeNode127 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("لوازم جانبی")
        Dim TreeNode128 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("حیوانات مزرعه")
        Dim TreeNode129 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سگ")
        Dim TreeNode130 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("حیوانات", New System.Windows.Forms.TreeNode() {TreeNode122, TreeNode123, TreeNode124, TreeNode125, TreeNode126, TreeNode127, TreeNode128, TreeNode129})
        Dim TreeNode131 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سکه، تمبر و اسکناس")
        Dim TreeNode132 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اشیای عتیقه")
        Dim TreeNode133 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کلکسیون و سرگرمی", New System.Windows.Forms.TreeNode() {TreeNode131, TreeNode132})
        Dim TreeNode134 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("گیتار، بیس و امپلیفایر")
        Dim TreeNode135 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سازهای بادی")
        Dim TreeNode136 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("پیانو/کیبورد/آکاردئون")
        Dim TreeNode137 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سنتی")
        Dim TreeNode138 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("درام و پرکاشن")
        Dim TreeNode139 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ویولن")
        Dim TreeNode140 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آلات موسیقی", New System.Windows.Forms.TreeNode() {TreeNode134, TreeNode135, TreeNode136, TreeNode137, TreeNode138, TreeNode139})
        Dim TreeNode141 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ورزش‌های توپی")
        Dim TreeNode142 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کوهنوردی و کمپینگ")
        Dim TreeNode143 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("غواصی و ورزش‌های آبی")
        Dim TreeNode144 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ماهیگیری")
        Dim TreeNode145 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تجهیزات ورزشی")
        Dim TreeNode146 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ورزش‌های زمستانی")
        Dim TreeNode147 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اسب و تجهیزات اسب سواری")
        Dim TreeNode148 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ورزش و تناسب اندام", New System.Windows.Forms.TreeNode() {TreeNode141, TreeNode142, TreeNode143, TreeNode144, TreeNode145, TreeNode146, TreeNode147})
        Dim TreeNode149 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اسباب‌ بازی")
        Dim TreeNode150 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سرگرمی و فراغت", 8, 8, New System.Windows.Forms.TreeNode() {TreeNode113, TreeNode114, TreeNode120, TreeNode121, TreeNode130, TreeNode133, TreeNode140, TreeNode148, TreeNode149})
        Dim TreeNode151 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("حراج")
        Dim TreeNode152 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("گردهمایی و همایش")
        Dim TreeNode153 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ورزشی")
        Dim TreeNode154 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("رویداد", New System.Windows.Forms.TreeNode() {TreeNode151, TreeNode152, TreeNode153})
        Dim TreeNode155 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تحقیقاتی")
        Dim TreeNode156 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("داوطلبانه", New System.Windows.Forms.TreeNode() {TreeNode155})
        Dim TreeNode157 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("حیوانات")
        Dim TreeNode158 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اشیا")
        Dim TreeNode159 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("گم‌شده‌ها", New System.Windows.Forms.TreeNode() {TreeNode157, TreeNode158})
        Dim TreeNode160 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اجتماعی", 9, 9, New System.Windows.Forms.TreeNode() {TreeNode154, TreeNode156, TreeNode159})
        Dim TreeNode161 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("فروشگاه و مغازه")
        Dim TreeNode162 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آرایشگاه و سالن‌های زیبایی")
        Dim TreeNode163 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("دفتر کار")
        Dim TreeNode164 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("صنعتی")
        Dim TreeNode165 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("کافی‌شاپ و رستوران")
        Dim TreeNode166 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("پزشکی")
        Dim TreeNode167 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تجهیزات و ماشین‌آلات", New System.Windows.Forms.TreeNode() {TreeNode161, TreeNode162, TreeNode163, TreeNode164, TreeNode165, TreeNode166})
        Dim TreeNode168 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("عمده فروشی")
        Dim TreeNode169 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("برای کسب و کار", 10, 10, New System.Windows.Forms.TreeNode() {TreeNode167, TreeNode168})
        Dim TreeNode170 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اداری و مدیریت")
        Dim TreeNode171 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("سرایداری و نظافت")
        Dim TreeNode172 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("معماری ،عمران و ساختمانی")
        Dim TreeNode173 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("خدمات فروشگاه و رستوران")
        Dim TreeNode174 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("رایانه و فناوری اطلاعات")
        Dim TreeNode175 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مالی و حسابداری و حقوقی")
        Dim TreeNode176 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("بازاریابی و فروش")
        Dim TreeNode177 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("صنعتی و فنی و مهندسی")
        Dim TreeNode178 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("آموزشی")
        Dim TreeNode179 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("حمل و نقل")
        Dim TreeNode180 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("درمانی و زیبایی و بهداشتی")
        Dim TreeNode181 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("هنری و رسانه")
        Dim TreeNode182 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("استخدام و کاریابی", 11, 11, New System.Windows.Forms.TreeNode() {TreeNode170, TreeNode171, TreeNode172, TreeNode173, TreeNode174, TreeNode175, TreeNode176, TreeNode177, TreeNode178, TreeNode179, TreeNode180, TreeNode181})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_main_window))
        Me.SplitContainer_main_window = New System.Windows.Forms.SplitContainer()
        Me.Button_search = New System.Windows.Forms.Button()
        Me.GroupBox_search_settings = New System.Windows.Forms.GroupBox()
        Me.TreeView_categories = New System.Windows.Forms.TreeView()
        Me.Label_search_exp = New System.Windows.Forms.Label()
        Me.ComboBox_city = New System.Windows.Forms.ComboBox()
        Me.TextBox_search_exp = New System.Windows.Forms.TextBox()
        Me.Label_city = New System.Windows.Forms.Label()
        Me.GroupBox_navigate = New System.Windows.Forms.GroupBox()
        Me.Button_refresh = New System.Windows.Forms.Button()
        Me.Button_forward = New System.Windows.Forms.Button()
        Me.Button_backward = New System.Windows.Forms.Button()
        Me.DataGridView_result = New System.Windows.Forms.DataGridView()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageList_icons = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip_all_info = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.تنظیماتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer_main_window.Panel1.SuspendLayout()
        Me.SplitContainer_main_window.Panel2.SuspendLayout()
        Me.SplitContainer_main_window.SuspendLayout()
        Me.GroupBox_search_settings.SuspendLayout()
        Me.GroupBox_navigate.SuspendLayout()
        CType(Me.DataGridView_result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer_main_window
        '
        Me.SplitContainer_main_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer_main_window.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_main_window.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer_main_window.Name = "SplitContainer_main_window"
        '
        'SplitContainer_main_window.Panel1
        '
        Me.SplitContainer_main_window.Panel1.Controls.Add(Me.Button_search)
        Me.SplitContainer_main_window.Panel1.Controls.Add(Me.GroupBox_search_settings)
        Me.SplitContainer_main_window.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer_main_window.Panel2
        '
        Me.SplitContainer_main_window.Panel2.Controls.Add(Me.GroupBox_navigate)
        Me.SplitContainer_main_window.Panel2.Controls.Add(Me.DataGridView_result)
        Me.SplitContainer_main_window.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer_main_window.Size = New System.Drawing.Size(800, 422)
        Me.SplitContainer_main_window.SplitterDistance = 266
        Me.SplitContainer_main_window.TabIndex = 0
        '
        'Button_search
        '
        Me.Button_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_search.Location = New System.Drawing.Point(9, 355)
        Me.Button_search.Name = "Button_search"
        Me.Button_search.Size = New System.Drawing.Size(244, 54)
        Me.Button_search.TabIndex = 1
        Me.Button_search.Text = "جستجو"
        Me.Button_search.UseVisualStyleBackColor = True
        '
        'GroupBox_search_settings
        '
        Me.GroupBox_search_settings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_search_settings.Controls.Add(Me.TreeView_categories)
        Me.GroupBox_search_settings.Controls.Add(Me.Label_search_exp)
        Me.GroupBox_search_settings.Controls.Add(Me.ComboBox_city)
        Me.GroupBox_search_settings.Controls.Add(Me.TextBox_search_exp)
        Me.GroupBox_search_settings.Controls.Add(Me.Label_city)
        Me.GroupBox_search_settings.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox_search_settings.Name = "GroupBox_search_settings"
        Me.GroupBox_search_settings.Size = New System.Drawing.Size(260, 337)
        Me.GroupBox_search_settings.TabIndex = 0
        Me.GroupBox_search_settings.TabStop = False
        Me.GroupBox_search_settings.Text = "تنظیمات جستجو"
        '
        'TreeView_categories
        '
        Me.TreeView_categories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView_categories.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView_categories.Location = New System.Drawing.Point(6, 113)
        Me.TreeView_categories.Name = "TreeView_categories"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = ""
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "همهٔ آگهی‌ها"
        TreeNode2.Name = "buy-apartment"
        TreeNode2.Text = "آپارتمان"
        TreeNode3.Name = "buy-villa"
        TreeNode3.Text = "خانه و ویلا"
        TreeNode4.Name = "buy-old-house"
        TreeNode4.Text = "زمین و کلنگی"
        TreeNode5.Name = "buy-residential"
        TreeNode5.Text = "فروش مسکونی"
        TreeNode6.Name = "rent-apartment"
        TreeNode6.Text = "آپارتمان"
        TreeNode7.Name = "rent-villa"
        TreeNode7.Text = "خانه و ویلا"
        TreeNode8.Name = "rent-residential"
        TreeNode8.Text = "اجاره مسکونی"
        TreeNode9.Name = "buy-office"
        TreeNode9.Text = "دفتر کار، اتاق اداری و مطب"
        TreeNode10.Name = "buy-store"
        TreeNode10.Text = "مغازه و غرفه"
        TreeNode11.Name = "buy-industrial-agricultural-property"
        TreeNode11.Text = "صنعتی،‌ کشاورزی و تجاری"
        TreeNode12.Name = "buy-commercial-property"
        TreeNode12.Text = "فروش اداری و تجاری"
        TreeNode13.Name = "rent-office"
        TreeNode13.Text = "دفتر کار، اتاق اداری و مطب"
        TreeNode14.Name = "rent-store"
        TreeNode14.Text = "مغازه و غرفه"
        TreeNode15.Name = "rent-industrial-agricultural-property"
        TreeNode15.Text = "صنعتی،‌ کشاورزی و تجاری"
        TreeNode16.Name = "rent-commercial-property"
        TreeNode16.Text = "اجاره اداری و تجاری"
        TreeNode17.Name = "rent-temporary-suite-apartment"
        TreeNode17.Text = "آپارتمان و سوئیت"
        TreeNode18.Name = "rent-temporary-villa"
        TreeNode18.Text = "ویلا و باغ"
        TreeNode19.Name = "rent-temporary-workspace"
        TreeNode19.Text = "دفتر کار و فضای آموزشی"
        TreeNode20.Name = "rent-temporary"
        TreeNode20.Text = "اجاره کوتاه مدت"
        TreeNode21.Name = "contribution-construction"
        TreeNode21.Text = "مشارکت در ساخت"
        TreeNode22.Name = "pre-sell-home"
        TreeNode22.Text = "پیش‌فروش"
        TreeNode23.Name = "real-estate-services"
        TreeNode23.Text = "پروژه‌های ساخت و ساز"
        TreeNode24.ImageIndex = 2
        TreeNode24.Name = "real-estate"
        TreeNode24.SelectedImageIndex = 2
        TreeNode24.Text = "املاک"
        TreeNode25.Name = "car"
        TreeNode25.Text = "سواری"
        TreeNode26.Name = "classic-car"
        TreeNode26.Text = "کلاسیک"
        TreeNode27.Name = "rental-car"
        TreeNode27.Text = "اجاره‌ای"
        TreeNode28.Name = "heavy-car"
        TreeNode28.Text = "سنگین"
        TreeNode29.Name = "auto"
        TreeNode29.Text = "خودرو"
        TreeNode30.Name = "car-accessories"
        TreeNode30.Text = "قطعات یدکی و لوازم جانبی خودرو"
        TreeNode31.Name = "motorcycles"
        TreeNode31.Text = "موتورسیکلت و لوازم جانبی"
        TreeNode32.Name = "boat"
        TreeNode32.Text = "قایق و لوازم جانبی"
        TreeNode33.ImageIndex = 3
        TreeNode33.Name = "vehicles"
        TreeNode33.SelectedImageIndex = 3
        TreeNode33.Text = "وسایل نقلیه"
        TreeNode34.Name = "mobile-phones"
        TreeNode34.Text = "گوشی موبایل"
        TreeNode35.Name = "tablet"
        TreeNode35.Text = "تبلت"
        TreeNode36.Name = "mobile-tablet-accessories"
        TreeNode36.Text = "لوازم جانبی موبایل و تبلت"
        TreeNode37.Name = "sim-card"
        TreeNode37.Text = "سیم کارت"
        TreeNode38.Name = "mobile-tablet"
        TreeNode38.Text = "موبایل و تبلت"
        TreeNode39.Name = "laptop-notebook-macbook"
        TreeNode39.Text = "رایانه همراه"
        TreeNode40.Name = "desktop-computer"
        TreeNode40.Text = "رایانه رومیزی"
        TreeNode41.Name = "computer-parts-accessories"
        TreeNode41.Text = "قطعات و لوازم جانبی"
        TreeNode42.Name = "modem-network-equipments"
        TreeNode42.Text = "مودم و تجهیزات شبکه"
        TreeNode43.Name = "printer-scanner-fax"
        TreeNode43.Text = "پرینتر/اسکنر/کپی/فکس"
        TreeNode44.Name = "computers"
        TreeNode44.Text = "رایانه"
        TreeNode45.Name = "game-consoles"
        TreeNode45.Text = "کنسول، بازی‌ ویدئویی و آنلاین"
        TreeNode46.Name = "film-music"
        TreeNode46.Text = "فیلم و موسیقی"
        TreeNode47.Name = "camera"
        TreeNode47.Text = "دوربین عکاسی و فیلم‌برداری"
        TreeNode48.Name = "headphone-speaker-microphone"
        TreeNode48.Text = "پخش‌کننده همراه"
        TreeNode49.Name = "home-audio-system"
        TreeNode49.Text = "سیستم صوتی خانگی"
        TreeNode50.Name = "dvd-bluray-player"
        TreeNode50.Text = "ویدئو و پخش کننده DVD"
        TreeNode51.Name = "tv-projector"
        TreeNode51.Text = "تلویزیون و پروژکتور"
        TreeNode52.Name = "cctv"
        TreeNode52.Text = "دوربین مداربسته"
        TreeNode53.Name = "video-audio-device"
        TreeNode53.Text = "صوتی و تصویری"
        TreeNode54.Name = "telephone"
        TreeNode54.Text = "تلفن رومیزی"
        TreeNode55.ImageIndex = 4
        TreeNode55.Name = "electronic-devices"
        TreeNode55.SelectedImageIndex = 4
        TreeNode55.Text = "لوازم الکترونیکی"
        TreeNode56.Name = "home-decor-furniture"
        TreeNode56.Text = "وسایل و تزئینات خانه"
        TreeNode57.Name = "kitchen-appliances"
        TreeNode57.Text = "وسایل آشپزخانه"
        TreeNode58.Name = "vacuum-cleaner-sewing-machine-iron"
        TreeNode58.Text = "نظافت و خیاطی و اتو"
        TreeNode59.Name = "power-and-hand-tools"
        TreeNode59.Text = "تعمیرات"
        TreeNode60.Name = "home-appliances"
        TreeNode60.Text = "ابزار"
        TreeNode61.Name = "bathroom-fixtures"
        TreeNode61.Text = "سرویس بهداشتی و سونا"
        TreeNode62.Name = "heating-cooling-systems"
        TreeNode62.Text = "سیستم گرمایشی سرمایشی و گاز"
        TreeNode63.Name = "kitchen-equipments"
        TreeNode63.Text = "آشپزخانه"
        TreeNode64.Name = "patio-balcony"
        TreeNode64.Text = "حیاط و ایوان"
        TreeNode65.Name = "garden-tools"
        TreeNode65.Text = "ابزار باغبانی"
        TreeNode66.Name = "building-garden"
        TreeNode66.Text = "ساختمان و حیاط"
        TreeNode67.ImageIndex = 5
        TreeNode67.Name = "home-and-kitchen"
        TreeNode67.SelectedImageIndex = 5
        TreeNode67.Text = "مربوط به خانه"
        TreeNode68.Name = "vehicles-services"
        TreeNode68.Text = "موتور و ماشین"
        TreeNode69.Name = "catering-services"
        TreeNode69.Text = "پذیرایی/مراسم"
        TreeNode70.Name = "domain-services"
        TreeNode70.Text = "فروش دامنه و سایت"
        TreeNode71.Name = "website-services"
        TreeNode71.Text = "میزبانی و طراحی سایت"
        TreeNode72.Name = "internet-services"
        TreeNode72.Text = "خدمات پهنای باند اینترنت"
        TreeNode73.Name = "computer-services"
        TreeNode73.Text = "خدمات نرم‌افزار و سخت‌افزار کامپیوتر"
        TreeNode74.Name = "mobile-services"
        TreeNode74.Text = "تعمیرات نرم‌افزار و سخت‌افزار گوشی موبایل"
        TreeNode75.Name = "technology-services"
        TreeNode75.Text = "خدمات رایانه‌ای و موبایل"
        TreeNode76.Name = "financial-services"
        TreeNode76.Text = "مالی/حسابداری/بیمه"
        TreeNode77.Name = "transport-logistic-services"
        TreeNode77.Text = "حمل و نقل"
        TreeNode78.Name = "craft-skill-services"
        TreeNode78.Text = "پیشه و مهارت"
        TreeNode79.Name = "beauty-services"
        TreeNode79.Text = "آرایشگری و زیبایی"
        TreeNode80.Name = "entertaining-services"
        TreeNode80.Text = "سرگرمی"
        TreeNode81.Name = "cleaning-services"
        TreeNode81.Text = "نظافت"
        TreeNode82.Name = "gardening-services"
        TreeNode82.Text = "باغبانی و درختکاری"
        TreeNode83.Name = "foreign-language"
        TreeNode83.Text = "زبان خارجی"
        TreeNode84.Name = "educational-teaching"
        TreeNode84.Text = "دروس مدرسه و دانشگاه"
        TreeNode85.Name = "software-teaching"
        TreeNode85.Text = "نرم‌افزار"
        TreeNode86.Name = "art-teaching"
        TreeNode86.Text = "هنری"
        TreeNode87.Name = "sports-teaching"
        TreeNode87.Text = "ورزشی"
        TreeNode88.Name = "educational-consulting"
        TreeNode88.Text = "مشاوره تحصیلی"
        TreeNode89.Name = "teaching-services"
        TreeNode89.Text = "آموزشی"
        TreeNode90.ImageIndex = 6
        TreeNode90.Name = "services"
        TreeNode90.SelectedImageIndex = 6
        TreeNode90.Text = "خدمات"
        TreeNode91.Name = "bag-shoes-belt"
        TreeNode91.Text = "کیف/کفش/کمربند"
        TreeNode92.Name = "clothing"
        TreeNode92.Text = "لباس"
        TreeNode93.Name = "apparel"
        TreeNode93.Text = "کیف، کفش و لباس"
        TreeNode94.Name = "watches"
        TreeNode94.Text = "ساعت"
        TreeNode95.Name = "jewellery"
        TreeNode95.Text = "جواهرات"
        TreeNode96.Name = "trinket"
        TreeNode96.Text = "بدلیجات"
        TreeNode97.Name = "accessories"
        TreeNode97.Text = "تزیینی"
        TreeNode98.Name = "beauty-and-personal-care"
        TreeNode98.Text = "آرایشی، بهداشتی و درمانی"
        TreeNode99.Name = "child-apparel"
        TreeNode99.Text = "کفش و لباس بچه"
        TreeNode100.Name = "child-toys"
        TreeNode100.Text = "اسباب بازی"
        TreeNode101.Name = "stroller"
        TreeNode101.Text = "کالسکه و لوازم جانبی"
        TreeNode102.Name = "child-furniture"
        TreeNode102.Text = "صندلی بچه"
        TreeNode103.Name = "child-stuff"
        TreeNode103.Text = "اسباب و اثاث بچه"
        TreeNode104.Name = "child-products"
        TreeNode104.Text = "وسایل بچه و اسباب بازی"
        TreeNode105.Name = "stationery"
        TreeNode105.Text = "لوازم التحریر"
        TreeNode106.ImageIndex = 7
        TreeNode106.Name = "personal-goods"
        TreeNode106.SelectedImageIndex = 7
        TreeNode106.Text = "وسایل شخصی"
        TreeNode107.Name = "concert-ticket"
        TreeNode107.Text = "کنسرت"
        TreeNode108.Name = "theatre-cinema-ticket"
        TreeNode108.Text = "تئاتر و سینما"
        TreeNode109.Name = "discount-gift-card"
        TreeNode109.Text = "کارت هدیه و تخفیف"
        TreeNode110.Name = "match-sport-ticket"
        TreeNode110.Text = "اماکن و مسابقات ورزشی"
        TreeNode111.Name = "sport-ticket"
        TreeNode111.Text = "ورزشی"
        TreeNode112.Name = "travel-ticket"
        TreeNode112.Text = "اتوبوس، مترو و قطار"
        TreeNode113.Name = "ticket"
        TreeNode113.Text = "بلیط"
        TreeNode114.Name = "tours"
        TreeNode114.Text = "تور و چارتر"
        TreeNode115.Name = "educational-book"
        TreeNode115.Text = "آموزشی"
        TreeNode116.Name = "literary-book"
        TreeNode116.Text = "ادبی"
        TreeNode117.Name = "historical-book"
        TreeNode117.Text = "تاریخی"
        TreeNode118.Name = "religious-book"
        TreeNode118.Text = "مذهبی"
        TreeNode119.Name = "magazine"
        TreeNode119.Text = "مجلات"
        TreeNode120.Name = "publication"
        TreeNode120.Text = "کتاب و مجله"
        TreeNode121.Name = "bike-skate-scooter"
        TreeNode121.Text = "دوچرخه/اسکیت/اسکوتر"
        TreeNode122.Name = "cats"
        TreeNode122.Text = "گربه"
        TreeNode123.Name = "rodents"
        TreeNode123.Text = "موش و خرگوش"
        TreeNode124.Name = "reptiles"
        TreeNode124.Text = "خزنده"
        TreeNode125.Name = "birds"
        TreeNode125.Text = "پرنده"
        TreeNode126.Name = "fishes"
        TreeNode126.Text = "ماهی"
        TreeNode127.Name = "pet-supplies"
        TreeNode127.Text = "لوازم جانبی"
        TreeNode128.Name = "farm-animals"
        TreeNode128.Text = "حیوانات مزرعه"
        TreeNode129.Name = "dogs"
        TreeNode129.Text = "سگ"
        TreeNode130.Name = "pets-animals"
        TreeNode130.Text = "حیوانات"
        TreeNode131.Name = "stamp-coin-collecting"
        TreeNode131.Text = "سکه، تمبر و اسکناس"
        TreeNode132.Name = "antique-objects"
        TreeNode132.Text = "اشیای عتیقه"
        TreeNode133.Name = "collecting"
        TreeNode133.Text = "کلکسیون و سرگرمی"
        TreeNode134.Name = "guitars"
        TreeNode134.Text = "گیتار، بیس و امپلیفایر"
        TreeNode135.Name = "wind-instrument"
        TreeNode135.Text = "سازهای بادی"
        TreeNode136.Name = "organ-piano-accordion"
        TreeNode136.Text = "پیانو/کیبورد/آکاردئون"
        TreeNode137.Name = "iranian-instruments"
        TreeNode137.Text = "سنتی"
        TreeNode138.Name = "percussion-instruments"
        TreeNode138.Text = "درام و پرکاشن"
        TreeNode139.Name = "violins"
        TreeNode139.Text = "ویولن"
        TreeNode140.Name = "musical-instruments"
        TreeNode140.Text = "آلات موسیقی"
        TreeNode141.Name = "ball-sports"
        TreeNode141.Text = "ورزش‌های توپی"
        TreeNode142.Name = "mountaineering-camping"
        TreeNode142.Text = "کوهنوردی و کمپینگ"
        TreeNode143.Name = "water-sports"
        TreeNode143.Text = "غواصی و ورزش‌های آبی"
        TreeNode144.Name = "fishing"
        TreeNode144.Text = "ماهیگیری"
        TreeNode145.Name = "sport-equipment"
        TreeNode145.Text = "تجهیزات ورزشی"
        TreeNode146.Name = "winter-sports"
        TreeNode146.Text = "ورزش‌های زمستانی"
        TreeNode147.Name = "horse-riding"
        TreeNode147.Text = "اسب و تجهیزات اسب سواری"
        TreeNode148.Name = "sport-entertainment"
        TreeNode148.Text = "ورزش و تناسب اندام"
        TreeNode149.Name = "game-and-toys"
        TreeNode149.Text = "اسباب‌ بازی"
        TreeNode150.ImageIndex = 8
        TreeNode150.Name = "entertainment"
        TreeNode150.SelectedImageIndex = 8
        TreeNode150.Text = "سرگرمی و فراغت"
        TreeNode151.Name = "auction"
        TreeNode151.Text = "حراج"
        TreeNode152.Name = "seminars-conference"
        TreeNode152.Text = "گردهمایی و همایش"
        TreeNode153.Name = "events-sports"
        TreeNode153.Text = "ورزشی"
        TreeNode154.Name = "event"
        TreeNode154.Text = "رویداد"
        TreeNode155.Name = "education-research-partner"
        TreeNode155.Text = "تحقیقاتی"
        TreeNode156.Name = "voluntary"
        TreeNode156.Text = "داوطلبانه"
        TreeNode157.Name = "lost-animals"
        TreeNode157.Text = "حیوانات"
        TreeNode158.Name = "lost-objects"
        TreeNode158.Text = "اشیا"
        TreeNode159.Name = "missing"
        TreeNode159.Text = "گم‌شده‌ها"
        TreeNode160.ImageIndex = 9
        TreeNode160.Name = "social-services"
        TreeNode160.SelectedImageIndex = 9
        TreeNode160.Text = "اجتماعی"
        TreeNode161.Name = "store-equipment"
        TreeNode161.Text = "فروشگاه و مغازه"
        TreeNode162.Name = "barber-shop-equipment"
        TreeNode162.Text = "آرایشگاه و سالن‌های زیبایی"
        TreeNode163.Name = "office-equipment"
        TreeNode163.Text = "دفتر کار"
        TreeNode164.Name = "industrial-equipment"
        TreeNode164.Text = "صنعتی"
        TreeNode165.Name = "restaurant-equipment"
        TreeNode165.Text = "کافی‌شاپ و رستوران"
        TreeNode166.Name = "medical-equipment"
        TreeNode166.Text = "پزشکی"
        TreeNode167.Name = "business-equipment"
        TreeNode167.Text = "تجهیزات و ماشین‌آلات"
        TreeNode168.Name = "wholesale"
        TreeNode168.Text = "عمده فروشی"
        TreeNode169.ImageIndex = 10
        TreeNode169.Name = "businesses"
        TreeNode169.SelectedImageIndex = 10
        TreeNode169.Text = "برای کسب و کار"
        TreeNode170.Name = "administrative-jobs"
        TreeNode170.Text = "اداری و مدیریت"
        TreeNode171.Name = "janitorial-jobs"
        TreeNode171.Text = "سرایداری و نظافت"
        TreeNode172.Name = "architect-jobs"
        TreeNode172.Text = "معماری ،عمران و ساختمانی"
        TreeNode173.Name = "service-jobs"
        TreeNode173.Text = "خدمات فروشگاه و رستوران"
        TreeNode174.Name = "it-computer-jobs"
        TreeNode174.Text = "رایانه و فناوری اطلاعات"
        TreeNode175.Name = "finance-legal-jobs"
        TreeNode175.Text = "مالی و حسابداری و حقوقی"
        TreeNode176.Name = "marketing-jobs"
        TreeNode176.Text = "بازاریابی و فروش"
        TreeNode177.Name = "technical-jobs"
        TreeNode177.Text = "صنعتی و فنی و مهندسی"
        TreeNode178.Name = "teaching-jobs"
        TreeNode178.Text = "آموزشی"
        TreeNode179.Name = "transport-delivery-jobs"
        TreeNode179.Text = "حمل و نقل"
        TreeNode180.Name = "health-beauty-jobs"
        TreeNode180.Text = "درمانی و زیبایی و بهداشتی"
        TreeNode181.Name = "art-media-jobs"
        TreeNode181.Text = "هنری و رسانه"
        TreeNode182.ImageIndex = 11
        TreeNode182.Name = "jobs"
        TreeNode182.SelectedImageIndex = 11
        TreeNode182.Text = "استخدام و کاریابی"
        Me.TreeView_categories.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode24, TreeNode33, TreeNode55, TreeNode67, TreeNode90, TreeNode106, TreeNode150, TreeNode160, TreeNode169, TreeNode182})
        Me.TreeView_categories.RightToLeftLayout = True
        Me.TreeView_categories.Size = New System.Drawing.Size(244, 218)
        Me.TreeView_categories.TabIndex = 4
        '
        'Label_search_exp
        '
        Me.Label_search_exp.AutoSize = True
        Me.Label_search_exp.Location = New System.Drawing.Point(6, 65)
        Me.Label_search_exp.Name = "Label_search_exp"
        Me.Label_search_exp.Size = New System.Drawing.Size(76, 17)
        Me.Label_search_exp.TabIndex = 3
        Me.Label_search_exp.Text = "عبارت جستجو"
        '
        'ComboBox_city
        '
        Me.ComboBox_city.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_city.FormattingEnabled = True
        Me.ComboBox_city.Items.AddRange(New Object() {"آبادان", "آباده", "آبدانان", "آبسرد", "آبعلی", "آبیک", "آذرشهر", "آران و بیدگل", "آزادشهر", "آسارا", "آستارا", "آستانه اشرفیه", "آشخانه", "آق قلا", "آمل", "ابریشم", "ابهر", "اراک", "ارجمند", "اردبیل", "اردکان", "ارومیه", "ازنا", "اسدآباد", "اسفراین", "اسلام‌‌آباد غرب", "اسلام‌شهر", "اشتهارد", "اشنویه", "اصفهان", "اقلید", "الوند", "الیگودرز", "املش", "امیرکلا", "اندیمشک", "اهر", "اهواز", "ایذه", "ایرانشهر", "ایزدشهر", "ایلام", "ایوان", "بابل", "بابلسر", "باقرشهر", "بانه", "بجنورد", "برازجان", "بردسکن", "بروجرد", "بروجن", "بم", "بناب", "بندر امام خمینی", "بندر انزلی", "بندر ترکمن", "بندرعباس", "بندر کنگان", "بندر گناوه", "بندر ماهشهر", "بوشهر", "بوکان", "بهبهان", "بهشهر", "بیجار", "بیرجند", "پارس‌آباد", "پل سفید", "پیرانشهر", "پیشوا", "تاکستان", "تالش", "تایباد", "تبریز", "تربت جام", "تنکابن", "تنکمان", "تویسرکان", "تهران", "جوادآباد", "جوانرود", "جویبار", "جهرم", "جیرفت", "چابکسر", "چابهار", "چاف و چمخاله", "چالوس", "چمستان", "چناران", "چهارباغ", "چهاردانگه", "حمیدیا", "خرم‌آباد", "خرمدره", "خرمشهر", "خشکبیجار", "خلخال", "خمین", "خواف", "خوانسار", "خوی", "داراب", "داران", "دامغان", "دزفول", "دماوند", "دورود", "دوگنبدان", "دهدشت", "دهلران", "رامسر", "رامهرمز", "رشت", "رضوانشهر", "رفسنجان", "رودسر", "رویان", "زابل", "زاهدان", "زرند", "زنجان", "زیباکنار", "ساری", "ساوه", "سبزوار", "سراب", "سراوان-سیستان و بلوچستان", "سرپل ذهاب", "سرخرود", "سردشت", "سقز", "سلماس", "سلمان‌شهر", "سمنان", "سمیرم", "سنقر", "سنندج", "سوسنگرد", "سهند", "سیاهکل", "سیرجان", "شاهدشهر", "شاهرود", "شاهین دژ", "شمشک", "شوش", "شوشتر", "شهرکرد", "شیراز", "شیروان", "صباشهر", "صدرا-فارس", "صفادشت", "صومعه‌سرا", "طالقان", "طبس", "عباس‌آباد", "علی‌آباد کتول", "فرخ‌شهر", "فردوس", "فردوسیه", "فریدون‌کنار", "فلاورجان", "فومن", "فیروزآباد", "قائم‌شهر", "قاسم‌آباد (خواف)", "قاين", "قروه", "قزوین", "قشم", "قم", "قیدار", "کاشان", "کرج", "کردکوی", "کرمان", "کرمانشاه", "کلاچای", "کلارآباد", "کلاردشت", "کلاله", "کنگاور", "کوهدشت", "کوهسار", "کهریزک", "کیاشهر", "کیش", "کیلان", "گرگان", "گرمدره", "گرمسار", "گلپایگان", "گلستان", "گمیشان", "گناباد", "گنبد کاووس", "لار", "لامرد", "لاهیجان", "لردگان", "لشت نشا", "لنگرود", "ماسال", "ماکو", "محلات", "محمدیه-قزوین", "محمودآباد", "مراغه", "مرند", "مریوان", "مسجد سلیمان", "مشکین‌شهر", "مشهد", "ملایر", "مهاباد", "میاندوآب", "میانه", "میبد", "میناب", "مینودشت", "نجف‌آباد", "نسیم‌شهر", "نظرآباد", "نقده", "نکا", "نور", "نورآباد", "نوشهر", "نهاوند", "نی‌ریز", "نیشابور", "وحیدیه", "همدان", "یاسوج", "یزد"})
        Me.ComboBox_city.Location = New System.Drawing.Point(6, 38)
        Me.ComboBox_city.Name = "ComboBox_city"
        Me.ComboBox_city.Size = New System.Drawing.Size(244, 24)
        Me.ComboBox_city.TabIndex = 2
        '
        'TextBox_search_exp
        '
        Me.TextBox_search_exp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_search_exp.Location = New System.Drawing.Point(6, 85)
        Me.TextBox_search_exp.Name = "TextBox_search_exp"
        Me.TextBox_search_exp.Size = New System.Drawing.Size(244, 22)
        Me.TextBox_search_exp.TabIndex = 1
        '
        'Label_city
        '
        Me.Label_city.AutoSize = True
        Me.Label_city.Location = New System.Drawing.Point(6, 18)
        Me.Label_city.Name = "Label_city"
        Me.Label_city.Size = New System.Drawing.Size(28, 17)
        Me.Label_city.TabIndex = 0
        Me.Label_city.Text = "شهر"
        '
        'GroupBox_navigate
        '
        Me.GroupBox_navigate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_navigate.Controls.Add(Me.Button_refresh)
        Me.GroupBox_navigate.Controls.Add(Me.Button_forward)
        Me.GroupBox_navigate.Controls.Add(Me.Button_backward)
        Me.GroupBox_navigate.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox_navigate.Name = "GroupBox_navigate"
        Me.GroupBox_navigate.Size = New System.Drawing.Size(522, 113)
        Me.GroupBox_navigate.TabIndex = 2
        Me.GroupBox_navigate.TabStop = False
        Me.GroupBox_navigate.Text = "پیمایش"
        '
        'Button_refresh
        '
        Me.Button_refresh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_refresh.Location = New System.Drawing.Point(291, 21)
        Me.Button_refresh.Name = "Button_refresh"
        Me.Button_refresh.Size = New System.Drawing.Size(71, 86)
        Me.Button_refresh.TabIndex = 2
        Me.Button_refresh.Text = "⟳"
        Me.ToolTip_all_info.SetToolTip(Me.Button_refresh, "بازنشانی")
        Me.Button_refresh.UseVisualStyleBackColor = True
        '
        'Button_forward
        '
        Me.Button_forward.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_forward.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_forward.Location = New System.Drawing.Point(368, 21)
        Me.Button_forward.Name = "Button_forward"
        Me.Button_forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_forward.Size = New System.Drawing.Size(71, 86)
        Me.Button_forward.TabIndex = 1
        Me.Button_forward.Text = "◀"
        Me.ToolTip_all_info.SetToolTip(Me.Button_forward, "صفحهٔ بعدی")
        Me.Button_forward.UseVisualStyleBackColor = True
        '
        'Button_backward
        '
        Me.Button_backward.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_backward.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_backward.Location = New System.Drawing.Point(445, 21)
        Me.Button_backward.Name = "Button_backward"
        Me.Button_backward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_backward.Size = New System.Drawing.Size(71, 86)
        Me.Button_backward.TabIndex = 0
        Me.Button_backward.Text = "▶"
        Me.ToolTip_all_info.SetToolTip(Me.Button_backward, "صفحهٔ قبلی")
        Me.Button_backward.UseVisualStyleBackColor = True
        '
        'DataGridView_result
        '
        Me.DataGridView_result.AllowUserToAddRows = False
        Me.DataGridView_result.AllowUserToDeleteRows = False
        Me.DataGridView_result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_result.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.title, Me.description})
        Me.DataGridView_result.Location = New System.Drawing.Point(3, 125)
        Me.DataGridView_result.Name = "DataGridView_result"
        Me.DataGridView_result.ReadOnly = True
        Me.DataGridView_result.RowHeadersVisible = False
        Me.DataGridView_result.RowHeadersWidth = 51
        Me.DataGridView_result.RowTemplate.Height = 24
        Me.DataGridView_result.Size = New System.Drawing.Size(522, 292)
        Me.DataGridView_result.TabIndex = 1
        '
        'title
        '
        Me.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.title.HeaderText = "عنوان"
        Me.title.MinimumWidth = 6
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.description.HeaderText = "قیمت"
        Me.description.MinimumWidth = 6
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        '
        'ImageList_icons
        '
        Me.ImageList_icons.ImageStream = CType(resources.GetObject("ImageList_icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_icons.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_icons.Images.SetKeyName(0, "flaticon_circumference_390933.ico")
        Me.ImageList_icons.Images.SetKeyName(1, "flaticon_brickwall_845059.ico")
        Me.ImageList_icons.Images.SetKeyName(2, "flaticon_home_1946488.ico")
        Me.ImageList_icons.Images.SetKeyName(3, "flaticon_car_633596.ico")
        Me.ImageList_icons.Images.SetKeyName(4, "flaticon_smartphone_244210.ico")
        Me.ImageList_icons.Images.SetKeyName(5, "icons8-lamp-64.ico")
        Me.ImageList_icons.Images.SetKeyName(6, "flaticon_paint-roller_2905134.ico")
        Me.ImageList_icons.Images.SetKeyName(7, "flaticon_smartwatch_4267843.ico")
        Me.ImageList_icons.Images.SetKeyName(8, "flaticon_console_686589.ico")
        Me.ImageList_icons.Images.SetKeyName(9, "flaticon_handshake_546448.ico")
        Me.ImageList_icons.Images.SetKeyName(10, "flaticon_manufacture_1433114.ico")
        Me.ImageList_icons.Images.SetKeyName(11, "flaticon_job-search_4150729.ico")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_about, Me.تنظیماتToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem_about
        '
        Me.ToolStripMenuItem_about.Name = "ToolStripMenuItem_about"
        Me.ToolStripMenuItem_about.Size = New System.Drawing.Size(118, 24)
        Me.ToolStripMenuItem_about.Text = "درباره دیوارچین"
        '
        'تنظیماتToolStripMenuItem
        '
        Me.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem"
        Me.تنظیماتToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.تنظیماتToolStripMenuItem.Text = "تنظیمات"
        '
        'Form_main_window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer_main_window)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_main_window"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "دیوارچین"
        Me.SplitContainer_main_window.Panel1.ResumeLayout(False)
        Me.SplitContainer_main_window.Panel2.ResumeLayout(False)
        Me.SplitContainer_main_window.ResumeLayout(False)
        Me.GroupBox_search_settings.ResumeLayout(False)
        Me.GroupBox_search_settings.PerformLayout()
        Me.GroupBox_navigate.ResumeLayout(False)
        CType(Me.DataGridView_result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer_main_window As SplitContainer
    Friend WithEvents GroupBox_search_settings As GroupBox
    Friend WithEvents Button_search As Button
    Friend WithEvents Label_search_exp As Label
    Friend WithEvents ComboBox_city As ComboBox
    Friend WithEvents TextBox_search_exp As TextBox
    Friend WithEvents Label_city As Label
    Friend WithEvents TreeView_categories As TreeView
    Friend WithEvents DataGridView_result As DataGridView
    Friend WithEvents ImageList_icons As ImageList
    Friend WithEvents GroupBox_navigate As GroupBox
    Friend WithEvents Button_forward As Button
    Friend WithEvents Button_backward As Button
    Friend WithEvents Button_refresh As Button
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip_all_info As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem_about As ToolStripMenuItem
    Friend WithEvents تنظیماتToolStripMenuItem As ToolStripMenuItem
End Class
