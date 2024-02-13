# Техническое задание

Разработать сайт с горизонтальным навигационным меню, состоящим из двух вкладок:
-	“О компании” (стартовая страница)
-	“Сотрудники”

На первой вкладке использовать произвольную верстку. При переходе на вкладку «сотрудники» должна появляться таблица, состоящая из колонок:
-	“Отдел”
-	“Ф.И.О”
-	“Дата рождения”
-	“Дата устройства на работу”
-	“Заработная плата”
-	“Создание/удаление/редактирование сотрудника”
  
Все что в таблице должно браться из базы данных MSSQL. Каждая колонка должна иметь фильтр(для даты это датапикер, для остальных текстовое поле) и сортировку.
В колонке “Создание/удаление/редактирование сотрудника” хедер должен быть пустой, в теле - три кнопки. При нажатии на кнопки “Создать” и “Редактировать” - открывается модальное окно с полями сотрудника, при нажатии на кнопку удалить - показывается модальное окно с подтверждением.

Все действия должны выполняться асинхронно т.е. без перезагрузки страницы.

Написать и приложить скрипты для: выборки всех сотрудников, сотрудников у кого зп выше 10000, удаления сотрудников старше 70 лет, обновить зп до 15000  тем сотрудникам, у которых она меньше.
