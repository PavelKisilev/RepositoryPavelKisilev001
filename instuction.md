**Git — это распределённая система управления версиями: есть один сервер, через который разработчики обмениваются кодом. Разработчик копирует (клонирует) проект к себе на локальную машину, делает изменения и сохраняет их на удалённый сервер. При необходимости другие разработчики могут скопировать эти изменения к себе.** - жирный

*Для начала зарегистрируйтесь на GitHub: задайте логин, почту и придумайте пароль. После «Создать аккаунт» не забудьте проверить почту и подтвердить её (опрос от Github после подтверждения почты можно пропустить).* - наклон


# Начало работы:  
Как мы отметили ранее, git хранит свои файлы и историю прямо в папке проекта. Чтобы создать новый репозиторий, нам нужно открыть терминал, зайти в папку нашего проекта и выполнить команду init. Это включит приложение в этой конкретной папке и создаст скрытую директорию .git, где будет храниться история репозитория и настройки.  (git init)

# Определение состояния
status — это еще одна важнейшая команда, которая показывает информацию о текущем состоянии репозитория: актуальна ли информация на нём, нет ли чего-то нового, что поменялось, и так далее. (git status)  


# Подготовка файлов
В git есть концепция области подготовленных файлов. Можно представить ее как холст, на который наносят изменения, которые нужны в коммите. Сперва он пустой, но затем мы добавляем на него файлы (или части файлов, или даже одиночные строчки) **командой add** и, наконец, коммитим все нужное в репозиторий (создаем слепок нужного нам состояния) **командой commit**.  

# Фиксация изменений
## Как сделать коммит
Представим, что нам нужно добавить пару новых блоков в html-разметку (index.html) и стилизовать их в файле style.css. Для сохранения изменений, их необходимо *закоммитить*. Но сначала, мы должны *обозначить эти файлы* для Гита, при помощи команды **git add**, добавляющей (или подготавливающей) их к коммиту. *Добавлять их можно по отдельности*:

**git add index.html**  
**git add css/style.css**  

*или вместе - всё сразу:*

**git add** .  
Конечно добавлять всё сразу удобнее, чем прописывать каждую позицию отдельно. Однако, тут надо быть внимательным, чтобы не добавить по ошибке ненужные элементы. Если же такое произошло изъять оттуда ошибочный файл можно при помощи команды

**git reset:**  
**git reset css/style.css**  
Теперь создадим непосредственно сам коммит

**git commit -m 'Add some code'**   
Флажок -m задаст commit message - *комментарий разработчика*.    
Он необходим для описания закоммиченных изменений. И здесь работает золотое правило всех комментариев в коде: «Максимально ясно, просто и содержательно обозначь написанное!»  

# Как посмотреть коммиты
Для просмотра все выполненных фиксаций можно воспользоваться историей коммитов. Она содержит сведения о каждом проведенном коммите проекта. Запросить ее можно при помощи команды:

**git log**  
В ней содержится вся информация о каждом отдельном коммите, с указанием его хэша, автора, списка изменений и даты, когда они были сделаны. Отследить интересующие вас операции в списке изменений, можно по хэшу коммита, при помощи команды git show :

**git show hash_commit**  
Ну а если вдруг нам нужно переделать commit message и внести туда новый комментарий, можно написать следующую конструкцию:

**git commit --amend -m 'Новый комментарий'**  
В данном случае сообщение последнего коммита перезапишется. Но злоупотреблять этим не стоит, поскольку эта операция опасная и лучше ее делать до отправки коммита на сервер.

# Удаленные репозитории
**Локальный** — существует только в директории .git на нашей файловой системе. Несмотря на то, что сам по себе локальный репозиторий полезен, в большинстве случаев мы хотим поделиться нашей работой или доставить код на сервер, где он будет выполняться.

## Что такое удаленный репозиторий
Репозиторий, хранящийся в облаке, на стороннем сервисе, специально созданном для работы с git имеет ряд преимуществ. Во-первых - это своего рода резервная копия вашего проекта, предоставляющая возможность безболезненной работы в команде. А еще в таком репозитории можно пользоваться дополнительными возможностями хостинга. К примеру -визуализацией истории или возможностью разрабатывать вашу программу непосредственно в веб-интерфейсе.
## Клонирование
**Клонирование** - это когда вы копируете удаленный репозиторий к себе на локальный ПК. Это то, с чего обычно начинается любой проект. При этом вы переносите себе все файлы и папки проекта, а также всю его историю с момента его создания. Чтобы склонировать проект, сперва, необходимо узнать где он расположен и скопировать ссылку на него.  
## Подключение к удаленному репозиторию
Чтобы загрузить что-нибудь в удаленный репозиторий, сначала нужно к нему подключиться. Регистрация и установка может занять время, но все подобные сервисы предоставляют хорошую документацию.
Чтобы связать наш локальный репозиторий с репозиторием на GitHub, выполним следующую команду в терминале. Обратите внимание, что нужно обязательно изменить URI репозитория на свой.  
**git remote add <имя репозитория> <адрес> (например: https://github.com/tutorialzine/awesome-project.git)**   

## Отправка изменений на сервер
Сейчас самое время переслать наш локальный коммит на сервер. Этот процесс происходит каждый раз, когда мы хотим обновить данные в удаленном репозитории.
Команда, предназначенная для этого - **push**. Она принимает два параметра: имя удаленного репозитория (мы назвали наш origin) и ветку, в которую необходимо внести изменения (master — это ветка по умолчанию для всех репозиториев).  
**git push <имя репозитория> <имя ветки>**  

*Подытожив сказанное, можно назвать git push - командой выгрузки, а git pull и git fetch - командами загрузки или скачивания. После того как вы успешно запушили измененные данные, их необходимо внедрить или интегрировать, при помощи команды слияния git merge.*

## Запрос изменений с сервера
Если вы сделали изменения в вашем удаленном репозитории, другие пользователи могут скачать изменения при помощи команды pull.

# Создание новой ветки
Основная ветка в каждом репозитории называется master. Чтобы создать еще одну ветку, используем команду  
**branch** <name>  
EX: git branch amazing_new_feature  

## Переключение между ветками
Сейчас, если мы запустим branch, мы увидим две доступные опции:

$ git branch  
amazing_new_feature  
*master 

*master* — это активная ветка, она помечена звездочкой. Но мы хотим работать с нашей “новой потрясающей фичей”, так что нам понадобится переключиться на другую ветку. Для этого воспользуемся командой **checkout**, она принимает один параметр — имя ветки, на которую необходимо переключиться.

$ git checkout amazing_new_feature  

**В Git ветка** — это отдельная линия разработки. **Git checkout** позволяет нам переключаться как между удаленными, так и меду локальными ветками. Это один из способов получить доступ к работе коллеги или соавтора, обеспечивающий более высокую продуктивность совместной работы. Однако тут надо помнить, что пока вы не закомитили изменения, вы не сможете переключиться на другую ветку. В такой ситуации нужно либо сделать коммит, либо отложить его, при помощи команды git stash, добавляющей текущие незакоммиченные изменения в стек изменений и сбрасывающей рабочую копию до HEAD'а репозитория.  

# Слияние веток
Наша “потрясающая новая фича” будет еще одним текстовым файлом под названием **feature.txt**. Мы создадим его, добавим и закоммитим:  

**git add feature.txt**  
**git commit -m "New feature complete.”**  

Изменения завершены, теперь мы можем переключиться обратно на ветку master.  

**$ git checkout master**

Теперь, если мы откроем наш проект в файловом менеджере, мы не увидим файла feature.txt, потому что мы переключились обратно на ветку master, в которой такого файла не существует. Чтобы он появился, нужно воспользоваться **merge** для объединения веток (применения изменений из ветки amazing_new_feature к основной версии проекта).  

**$ git merge amazing_new_feature**  

Теперь ветка master актуальна. Ветка amazing_new_feature больше не нужна, и ее можно удалить.

**$ git branch -d awesome_new_feature**  

Если хотите создать копию удаленного репозитория - используйте **git clone**. Однако если вам нужна только определенная его ветка, а не все хранилище - после **git clone** выполните следующую команду в соответствующем репозитории:

**git checkout -b <имя ветки> origin/<имя ветки>**  

После этого, новая ветка создается на машине автоматически.

# Как удалять ветки в Git?
Бывают ситуации, когда после слива каких-то изменений из рабочей ветки в исходную версию проекта, ее, по правилам хорошего тона, необходимо удалить, чтобы она более не мешалась в вашем коде. Но как это сделать?
Для локально расположенных веток существует команда:

**git branch -d local_branch_name**
где флажок **-d** являющийся опцией команды **git branch** - это сокращенная версия ключевого слова **--delete**, предназначенного *для удаления ветки*, а **local_branch_name** – *название ненужной нам ветки*.
Однако тут есть нюанс: *удалить текущую ветку, в которую вы, в данный момент просматриваете - нельзя*. Если же вы все-таки попытаетесь это сделать, система отругает вас и выдаст ошибку с таким содержанием:

Error: Cannot delete branch local_branch_name checked out at название_директории
Так что при удалении ветвей, обязательно переключитесь на другой branch.

# Дополнительно
*В последней части этого руководства мы расскажем о некоторых дополнительных трюках, которые могут вам помочь.*

## Отслеживание изменений, сделанных в коммитах
У каждого коммита есть свой *уникальный идентификатор* в виде строки цифр и букв. Чтобы просмотреть список всех коммитов и их идентификаторов, можно использовать команду **log**:
[spoiler title='Вывод git log']

**$ git log**  
commit ba25c0ff30e1b2f0259157b42b9f8f5d174d80d7  
Author: Tutorialzine  
Date: Mon May 30 17:15:28 2016 +0300  
New feature complete  
commit b10cc1238e355c02a044ef9f9860811ff605c9b4  
Author: Tutorialzine  
Date: Mon May 30 16:30:04 2016 +0300  
Added content to hello.txt  
commit 09bd8cc171d7084e78e4d118a2346b7487dca059  
Author: Tutorialzine  
Date: Sat May 28 17:52:14 2016 +0300  
Initial commit  
[/spoiler]  
Как вы можете заметить, идентификаторы довольно длинные, но для работы с ними не обязательно копировать их целиком  
   **первых нескольких символов будет вполне достаточно**.  
 Чтобы посмотреть, что нового появилось в коммите, мы можем воспользоваться командой show [commit]
[spoiler title='Вывод git show']

**$ git show b10cc123**  
commit b10cc1238e355c02a044ef9f9860811ff605c9b4  
Author: Tutorialzine  
Date: Mon May 30 16:30:04 2016 +0300  
Added content to hello.txt  
diff --git a/hello.txt b/hello.txt  
index e69de29..b546a21 100644  
--- a/hello.txt  
+++ b/hello.txt  
@@ -0,0 +1 @@  
+Nice weather today, isn't it?  
[/spoiler]  
Чтобы увидеть разницу между двумя коммитами, используется команда diff (с указанием промежутка между коммитами):
[spoiler title='Вывод git diff']

**$ git diff 09bd8cc..ba25c0ff**  
diff --git a/feature.txt b/feature.txt  
new file mode 100644  
index 0000000..e69de29  
diff --git a/hello.txt b/hello.txt  
index e69de29..b546a21 100644  
--- a/hello.txt  
+++ b/hello.txt  
@@ -0,0 +1 @@  
+Nice weather today, isn't it?  
[/spoiler]  
Мы сравнили первый коммит с последним, чтобы увидеть все изменения, которые были когда-либо сделаны. Обычно проще использовать **git difftool**, так как эта команда **запускает графический клиент**, в котором наглядно сопоставляет все изменения.

## Возвращение файла к предыдущему состоянию  
Гит позволяет вернуть выбранный файл к состоянию на момент определенного коммита. Это делается уже знакомой нам командой **checkout**, которую мы ранее использовали для переключения между ветками. Но она также может быть использована для переключения между коммитами (это довольно распространенная ситуация для Гита - использование одной команды для различных, на первый взгляд, слабо связанных задач).
В следующем примере мы возьмем файл hello.txt и откатим все изменения, совершенные над ним к первому коммиту. Чтобы сделать это, мы подставим в команду идентификатор нужного коммита, а также путь до файла:

$ git checkout 09bd8cc1 hello.txt  

## Исправление коммита

Если вы опечатались в комментарии или забыли добавить файл и заметили это сразу после того, как закоммитили изменения, вы легко можете это поправить при помощи **commit —amend**.  
Эта команда добавит все из последнего коммита в область подготовленных файлов и попытается сделать новый коммит. Это дает вам возможность поправить комментарий или добавить недостающие файлы в область подготовленных файлов.
Для более сложных исправлений, например, не в последнем коммите или если вы успели отправить изменения на сервер, нужно использовать **revert**. **Эта команда создаст коммит, отменяющий изменения, совершенные в коммите с заданным идентификатором.**
Самый последний коммит может быть доступен по алиасу HEAD:

**$ git revert HEAD**  
Для остальных будем использовать идентификаторы:

**$ git revert b10cc123**  
При отмене старых коммитов нужно быть готовым к тому, что **возникнут конфликты**. Такое случается, если файл был изменен еще одним, более новым коммитом. И теперь *git не может найти строчки, состояние которых нужно откатить, так как они больше не существуют*.

## Разрешение конфликтов при слиянии
Помимо сценария, описанного в предыдущем пункте, конфликты регулярно возникают при слиянии ветвей или при отправке чужого кода. Иногда конфликты исправляются автоматически, но обычно с этим приходится *разбираться вручную — решать, какой код остается, а какой нужно удалить.*
Давайте посмотрим на примеры, где мы попытаемся слить две ветки под названием john_branch и tim_branch. И Тим, и Джон правят один и тот же файл: функцию, которая отображает элементы массива.
Джон использует цикл:

// Use a for loop to console.log contents.  
for(var i=0; i<arr.length; i++)  
{  
console.log(arr[i]);  
}  
Тим предпочитает forEach:  

// Use forEach to console.log contents.  
arr.forEach(function(item)  
{
console.log(item);  
});  
Они оба коммитят свой код в соответствующую ветку. Теперь, если они попытаются слить две ветки, они получат сообщение об ошибке:

**$ git merge tim_branch ** 
Auto-merging print_array.js  
CONFLICT (content): Merge conflict in print_array.js  
Automatic merge failed; fix conflicts and then commit the result.  

Система не смогла разрешить конфликт автоматически, значит, это придется сделать разработчикам. Приложение отметило строки, содержащие конфликт:
[spoiler title='Вывод']

<<<<<<< HEAD // Use a for loop to console.log contents. for(var i=0; i<arr.length; i++) { console.log(arr[i]); } ======= // Use forEach to console.log contents. arr.forEach(function(item) { console.log(item); }); >>>>>>> Tim's commit.
[/spoiler]

Над разделителем ======= мы видим последний (HEAD) коммит, а под ним - конфликтующий. Таким образом, мы можем увидеть, чем они отличаются и решать, какая версия лучше. Или вовсе написать новую. В этой ситуации мы так и поступим, перепишем все, удалив разделители, и дадим git понять, что закончили.

// Not using for loop or forEach.
// Use Array.toString() to console.log contents.
console.log(arr.toString());
Когда все готово, нужно закоммитить изменения, чтобы закончить процесс:

**$ git add -A**
**$ git commit -m "Array printing conflict resolved."**  

Как вы можете заметить, процесс довольно утомительный и может быть очень сложным в больших проектах. Многие разработчики предпочитают использовать **для разрешения конфликтов клиенты с графическим интерфейсом**. (Для запуска нужно набрать **git mergetool**).




# Настройка .gitignore
В большинстве проектов есть файлы или целые директории, в которые мы не хотим (и, скорее всего, не захотим) коммитить. Мы можем удостовериться, что они случайно не попадут в git add -A при помощи файла .gitignore

Создайте вручную файл под названием .gitignore и сохраните его в директорию проекта.
Внутри файла перечислите названия файлов/папок, которые нужно игнорировать, каждый с новой строки.
Файл .gitignore должен быть добавлен, закоммичен и отправлен на сервер, как любой другой файл в проекте.
Вот хорошие примеры файлов, которые нужно игнорировать:

Логи  
Артефакты систем сборки  
Папки node_modules в проектах node.js  
Папки, созданные IDE, например, Netbeans или IntelliJ  
Разнообразные заметки разработчика.  
Файл .gitignore, исключающий все перечисленное выше, будет выглядеть так:

*.log  
build/  
node_modules/  
.idea/  
my_notes.txt  
Символ слэша в конце некоторых линий означает директорию (и тот факт, что мы рекурсивно игнорируем все ее содержимое). Звездочка, как обычно, означает шаблон.