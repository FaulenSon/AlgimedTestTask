# AlgimedTestTask
 Test task for company
## Task
<p>
<b>Основная цель:</b>
Написание десктоп приложения на C# .Net 4 и выше с сохранением результатов в локальную sql базу и отображением этих результатов на форме в виде чтения из SQL базы.
Результат должен быть предоставлен в виде инсталляционного пакета.
</p>
<p>
 <b>Обзор функционала разрабатываемого ПО:</b>
 <p>
  <ul>
   <li>В качестве локальной БД может использоваться SQL lite, sdf либо любой другой аналог</li>
   <li>WPF или WinForms для формы</li>
   <li>Вход в приложение должен быть запаролен, пароль будет хранится в локальной базе данных</li>
   <li>Доступ в БД должен быть запаролен</li>
  </ul>
 </p>
</p>
<p>
 <b>Логика расчетов:</b>
1)	Использовать данные из файла Input Data.xlsx.
Данные предоставлены в таком виде:
<img src="https://i.ibb.co/f9GVcqv/5.png" width="426">
</p>
<p>
 2)	Из колонки A для ячеек C01, D01 и F01 найти значения из колонки F, к примеру для С01 значение составляет 25.05. Должны получится такие соответствия:
 </p>
 <img src="https://i.ibb.co/6DyKL0s/6.png" width="426">
<p>
 3)	Составить матрицу результатов:
 <img src="https://i.ibb.co/VBDrq3n/7.png" width="426">
 <p>
  Где, на пересечение ячеек формула на примере ячеек C01 и E01; Result = (C01 – E01)^2
 </p>
</p>
<p>
 4)	Сохранить результат расчета в sql базу в таком виде:
 <img src="https://i.ibb.co/6HRLd7n/8.png" width="426">
</p>
<p>
 <p>
  5)	Отобразить созраненные результаты на форме
 </p>
</p>
