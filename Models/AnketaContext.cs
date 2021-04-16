using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ATOM.Models
{
    public class AnketaContext : DbContext
    {
        public AnketaContext() : base("AnketaConnection") { }

        //************   Kettel Test   ****************************

        public DbSet<KT_Question> KT_Questions { get; set; }
        public DbSet<KT_Answer> KT_Answers { get; set; }
        public DbSet<KT_Category> KT_Categories { get; set; }
        public DbSet<KT_KeysForCategory> KT_KeysForCategories { get; set; }
        public DbSet<KT_Mark> KT_Marks { get; set; }
        public DbSet<KT_TestableAnswer> KT_TestableAnswers { get; set; }
        public DbSet<KT_TestableMarkMain> KT_TestableMarkMain { get; set; }
        public DbSet<KT_TestableMarkCategory> KT_TestableMarkCategory { get; set; }
    }

    public class DbAnketaInitializer : CreateDatabaseIfNotExists<AnketaContext>
    //public class DbAnketaInitializer : DropCreateDatabaseIfModelChanges<AnketaContext>
    {
        protected override void Seed(AnketaContext context)
        {  
            context.KT_Questions.Add(new KT_Question { ID = 1, NumberQuestion = 1, TextQuestion = "Я хорошо понял  инструкцию, которую только что  прочитал:" });
            context.KT_Questions.Add(new KT_Question { ID = 2, NumberQuestion = 2, TextQuestion = "И готов отвечать на каждый  вопрос так искренне, как только  возможно:" });
            context.KT_Questions.Add(new KT_Question { ID = 3, NumberQuestion = 3, TextQuestion = "Я бы предпочел временами жить в доме, который находится:" });
            context.KT_Questions.Add(new KT_Question { ID = 4, NumberQuestion = 4, TextQuestion = "Я чувствую в себе достаточно  сил, чтобы справиться со своими  трудностями:" });
            context.KT_Questions.Add(new KT_Question { ID = 5, NumberQuestion = 5, TextQuestion = "Я чувствую некоторое беспокойство при виде диких животных, даже если они находятся в прочных клетках:" });
            context.KT_Questions.Add(new KT_Question { ID = 6, NumberQuestion = 6, TextQuestion = "Я воздерживаюсь от критики  людей и их высказываний:" });
            context.KT_Questions.Add(new KT_Question { ID = 7, NumberQuestion = 7, TextQuestion = "Я делаю саркастические (язвительные) замечания по поводу людей, если они этого, по-моему, заслуживают:" });
            context.KT_Questions.Add(new KT_Question { ID = 8, NumberQuestion = 8, TextQuestion = "Мне больше нравится классическая, чем эстрадная музыка:" });
            context.KT_Questions.Add(new KT_Question { ID = 9, NumberQuestion = 9, TextQuestion = "Если бы я увидел дерущимися  соседских детей, то я:" });
            context.KT_Questions.Add(new KT_Question { ID = 10, NumberQuestion = 10, TextQuestion = "При общении с людьми я:" });
            context.KT_Questions.Add(new KT_Question { ID = 11, NumberQuestion = 11, TextQuestion = "По-моему, интереснее быть:" });
            context.KT_Questions.Add(new KT_Question { ID = 12, NumberQuestion = 12, TextQuestion = "Я остановился бы на улице  скорее, чтобы посмотреть на работу  художника, чем слушать, как ссорятся  люди:" });
            context.KT_Questions.Add(new KT_Question { ID = 13, NumberQuestion = 13, TextQuestion = "Обычно я могу ладить с самодовольными  людьми, несмотря на то, что они  хвастаются или слишком много о себе воображают:" });
            context.KT_Questions.Add(new KT_Question { ID = 14, NumberQuestion = 14, TextQuestion = "По лицу человека всегда можно  заметить, что он нечестный:" });
            context.KT_Questions.Add(new KT_Question { ID = 15, NumberQuestion = 15, TextQuestion = "Было бы хорошо, если бы отпуск (каникулы) был более продолжителен, и каждый был бы обязан его использовать:" });
            context.KT_Questions.Add(new KT_Question { ID = 16, NumberQuestion = 16, TextQuestion = "Я предпочел бы работу с  возможно большим, но непостоянным  заработком, чем работу со скромным, но постоянным окладом:" });
            context.KT_Questions.Add(new KT_Question { ID = 17, NumberQuestion = 17, TextQuestion = "Я говорю о своих чувствах:" });
            context.KT_Questions.Add(new KT_Question { ID = 18, NumberQuestion = 18, TextQuestion = "Время от времени у меня  возникает чувство неопределенной  опасности или внезапного страха  по непонятным причинам:" });
            context.KT_Questions.Add(new KT_Question { ID = 19, NumberQuestion = 19, TextQuestion = "Когда меня неправильно критикуют  за что-то, в чем я не виноват, я:" });
            context.KT_Questions.Add(new KT_Question { ID = 20, NumberQuestion = 20, TextQuestion = "За деньги можно купить почти  все:" });
            context.KT_Questions.Add(new KT_Question { ID = 21, NumberQuestion = 21, TextQuestion = "Моим решением руководит больше:" });
            context.KT_Questions.Add(new KT_Question { ID = 22, NumberQuestion = 22, TextQuestion = "Большинство людей  были бы больше счастливы, если  бы они были ближе друг к  другу и поступали так же, как  все:" });
            context.KT_Questions.Add(new KT_Question { ID = 23, NumberQuestion = 23, TextQuestion = "Иногда, когда я смотрю в зеркало, мне трудно разобраться, где у меня правая, а где левая сторона:" });
            context.KT_Questions.Add(new KT_Question { ID = 24, NumberQuestion = 24, TextQuestion = "При разговоре я предпочитаю:" });
            context.KT_Questions.Add(new KT_Question { ID = 25, NumberQuestion = 25, TextQuestion = "После того как меня что-то  сильно рассердит, я довольно  быстро успокаиваюсь:" });
            context.KT_Questions.Add(new KT_Question { ID = 26, NumberQuestion = 26, TextQuestion = "При одинаковом рабочем времени  и заработке было бы интереснее  работать:" });
            context.KT_Questions.Add(new KT_Question { ID = 27, NumberQuestion = 27, TextQuestion = "На общественные должности меня  выбирали:" });
            context.KT_Questions.Add(new KT_Question { ID = 28, NumberQuestion = 28, TextQuestion = "«Лопата» относится к «копать», как «нож» относится к:" });
            context.KT_Questions.Add(new KT_Question { ID = 29, NumberQuestion = 29, TextQuestion = "Иногда я не могу заснуть  потому что какая-нибудь мысль не выходит из головы:" });
            context.KT_Questions.Add(new KT_Question { ID = 30, NumberQuestion = 30, TextQuestion = "В своей жизни я почти всегда  достигаю поставленных целей:" });
            context.KT_Questions.Add(new KT_Question { ID = 31, NumberQuestion = 31, TextQuestion = "Устаревший закон следует изменить:" });
            context.KT_Questions.Add(new KT_Question { ID = 32, NumberQuestion = 32, TextQuestion = "Я чувствую себя  «не в своей тарелке», когда  мне приходится работать над  чем-нибудь, что требует быстрых  действий, результаты которых могут  повлиять на других людей:" });
            context.KT_Questions.Add(new KT_Question { ID = 33, NumberQuestion = 33, TextQuestion = "Большинство знакомых считают меня интересным рассказчиком:" });
            context.KT_Questions.Add(new KT_Question { ID = 34, NumberQuestion = 34, TextQuestion = "Когда я вижу неряшливых, неопрятных  людей, я:" });
            context.KT_Questions.Add(new KT_Question { ID = 35, NumberQuestion = 35, TextQuestion = "Я чувствую себя немного не по себе, если неожиданно оказываюсь в центре внимания группы людей:" });
            context.KT_Questions.Add(new KT_Question { ID = 36, NumberQuestion = 36, TextQuestion = "Я всегда рад оказаться среди  людей, например, в гостях, на танцах, коллективной встрече:" });
            context.KT_Questions.Add(new KT_Question { ID = 37, NumberQuestion = 37, TextQuestion = "В школе я предпочитал (или предпочитаю):" });
            context.KT_Questions.Add(new KT_Question { ID = 38, NumberQuestion = 38, TextQuestion = "Если меня назначают  руководителем чего-либо, я настаиваю  на том, чтобы мои указания  выполнялись, иначе я отказываюсь  от этой работы:" });
            context.KT_Questions.Add(new KT_Question { ID = 39, NumberQuestion = 39, TextQuestion = "Важнее, чтобы родители:" });
            context.KT_Questions.Add(new KT_Question { ID = 40, NumberQuestion = 40, TextQuestion = "Участвуя в групповой деятельности, я бы предпочел:" });
            context.KT_Questions.Add(new KT_Question { ID = 41, NumberQuestion = 41, TextQuestion = "Время от времени у меня  появляется потребность в интересной  физической деятельности:" });
            context.KT_Questions.Add(new KT_Question { ID = 42, NumberQuestion = 42, TextQuestion = "Я предпочел бы скорее общаться  с вежливыми людьми, чем с грубоватыми и любящими возражать:" });
            context.KT_Questions.Add(new KT_Question { ID = 43, NumberQuestion = 43, TextQuestion = "Я чувствую себя очень униженным, когда меня критикуют в присутствии  группы людей:" });
            context.KT_Questions.Add(new KT_Question { ID = 44, NumberQuestion = 44, TextQuestion = "Если меня вызывает начальство, то я:" });
            context.KT_Questions.Add(new KT_Question { ID = 45, NumberQuestion = 45, TextQuestion = "В наше время требуется:" });
            context.KT_Questions.Add(new KT_Question { ID = 46, NumberQuestion = 46, TextQuestion = "При чтении я сразу замечаю, когда автор произведения хочет  меня в чем-то убедить:" });
            context.KT_Questions.Add(new KT_Question { ID = 47, NumberQuestion = 47, TextQuestion = "В юности я принимал участие  в нескольких спортивных мероприятиях:" });
            context.KT_Questions.Add(new KT_Question { ID = 48, NumberQuestion = 48, TextQuestion = "Я поддерживаю порядок в моей комнате, все вещи всегда лежат на своих местах:" });
            context.KT_Questions.Add(new KT_Question { ID = 49, NumberQuestion = 49, TextQuestion = "Иногда у меня  возникает чувство напряжения  и беспокойства, когда я вспоминаю, что произошло в течение дня:" });
            context.KT_Questions.Add(new KT_Question { ID = 50, NumberQuestion = 50, TextQuestion = "Иногда я сомневаюсь, действительно ли люди, с которыми я разговариваю, интересуются тем, что я говорю:" });
            context.KT_Questions.Add(new KT_Question { ID = 51, NumberQuestion = 51, TextQuestion = "Если бы пришлось выбирать, то  я предпочел бы быть:" });
            context.KT_Questions.Add(new KT_Question { ID = 52, NumberQuestion = 52, TextQuestion = "На праздники и дни рождения я:" });
            context.KT_Questions.Add(new KT_Question { ID = 53, NumberQuestion = 53, TextQuestion = "«Усталый» относится к «работе», как «гордый» к:" });
            context.KT_Questions.Add(new KT_Question { ID = 54, NumberQuestion = 54, TextQuestion = "Какой из следующих предметов  по существу отличается от двух других:" });
            context.KT_Questions.Add(new KT_Question { ID = 55, NumberQuestion = 55, TextQuestion = "Друзья меня подводили:" });
            context.KT_Questions.Add(new KT_Question { ID = 56, NumberQuestion = 56, TextQuestion = "У меня есть качества, по которым  я определенно выше большинства  людей:" });
            context.KT_Questions.Add(new KT_Question { ID = 57, NumberQuestion = 57, TextQuestion = "Когда я расстроен, я стараюсь скрыть свои чувства от других:" });
            context.KT_Questions.Add(new KT_Question { ID = 58, NumberQuestion = 58, TextQuestion = "Я склонен посещать зрелищные  мероприятия и развлечения:" });
            context.KT_Questions.Add(new KT_Question { ID = 59, NumberQuestion = 59, TextQuestion = "Я считаю, что  возможность вести себя непринужденно  важнее, чем хорошие манеры и  уважение к существующим правилам  поведения:" });
            context.KT_Questions.Add(new KT_Question { ID = 60, NumberQuestion = 60, TextQuestion = "Обычно я молчу в присутствии  старших по возрасту, опыту и положению:" });
            context.KT_Questions.Add(new KT_Question { ID = 61, NumberQuestion = 61, TextQuestion = "Мне трудно говорить или декламировать  перед большой группой людей:" });
            context.KT_Questions.Add(new KT_Question { ID = 62, NumberQuestion = 62, TextQuestion = "У меня хорошее  чувство ориентировки в незнакомом  месте (мне легко сказать, где  север – восток – юг – запад):" });
            context.KT_Questions.Add(new KT_Question { ID = 63, NumberQuestion = 63, TextQuestion = "Если кто-нибудь рассердится на  меня, то я:" });
            context.KT_Questions.Add(new KT_Question { ID = 64, NumberQuestion = 64, TextQuestion = "Встречаясь с несправедливостью, я скорее склонен забыть об  этом, чем реагировать:" });
            context.KT_Questions.Add(new KT_Question { ID = 65, NumberQuestion = 65, TextQuestion = "Из моей памяти часто выпадают  несущественные тривиальные вещи, например, названия улиц, магазинов:" });
            context.KT_Questions.Add(new KT_Question { ID = 66, NumberQuestion = 66, TextQuestion = "Мне бы понравилась жизнь ветеринара, лечение и операции на животных:" });
            context.KT_Questions.Add(new KT_Question { ID = 67, NumberQuestion = 67, TextQuestion = "Я ем со вкусом, не всегда  так аккуратно и тщательно  как другие люди:" });
            context.KT_Questions.Add(new KT_Question { ID = 68, NumberQuestion = 68, TextQuestion = "Бывают времена, когда у меня  нет настроения видеть кого  бы то ни было:" });
            context.KT_Questions.Add(new KT_Question { ID = 69, NumberQuestion = 69, TextQuestion = "Иногда меня предупреждают о  том, что в моем голосе и  манерах слишком проявляется  возбуждение:" });
            context.KT_Questions.Add(new KT_Question { ID = 70, NumberQuestion = 70, TextQuestion = "В юности, если я расходился  во мнении с родителями, то  я:" });
            context.KT_Questions.Add(new KT_Question { ID = 71, NumberQuestion = 71, TextQuestion = "Я предпочел бы заниматься  самостоятельной работой, а не  совместной с другими:" });
            context.KT_Questions.Add(new KT_Question { ID = 72, NumberQuestion = 72, TextQuestion = "Мне бы больше понравилась  спокойная жизнь, чем слава и  шумный успех:" });
            context.KT_Questions.Add(new KT_Question { ID = 73, NumberQuestion = 73, TextQuestion = "В большинстве случаев я чувствую себя зрелым человеком:" });
            context.KT_Questions.Add(new KT_Question { ID = 74, NumberQuestion = 74, TextQuestion = "Замечания в  мой адрес, которые позволяют  себе некоторые люди, меня больше  расстраивают, чем помогают:" });
            context.KT_Questions.Add(new KT_Question { ID = 75, NumberQuestion = 75, TextQuestion = "Я всегда способен управлять проявлением своих чувств:" });
            context.KT_Questions.Add(new KT_Question { ID = 76, NumberQuestion = 76, TextQuestion = "Начиная работу над полезным  изобретением, я бы предпочел:" });
            context.KT_Questions.Add(new KT_Question { ID = 77, NumberQuestion = 77, TextQuestion = "«Удивление» относится к «странный», как «страх» относится к:" });
            context.KT_Questions.Add(new KT_Question { ID = 78, NumberQuestion = 78, TextQuestion = "Которая из последующих дробей  отличается от двух других:" });
            context.KT_Questions.Add(new KT_Question { ID = 79, NumberQuestion = 79, TextQuestion = "Кажется, некоторые люди игнорируют  и избегают меня, хотя я не  знаю, почему:" });
            context.KT_Questions.Add(new KT_Question { ID = 80, NumberQuestion = 80, TextQuestion = "Отношения ко мне людей не  соответствуют моим добрым намерениям:" });
            context.KT_Questions.Add(new KT_Question { ID = 81, NumberQuestion = 81, TextQuestion = "Употребление нецензурных выражений  вызывает у меня возмущение, даже  если не присутствуют лица  другого пола:" });
            context.KT_Questions.Add(new KT_Question { ID = 82, NumberQuestion = 82, TextQuestion = "У меня определенно меньше  друзей, чем у большинства людей:" });
            context.KT_Questions.Add(new KT_Question { ID = 83, NumberQuestion = 83, TextQuestion = "Я бы очень не хотел находиться  в таком месте, где нет таких  людей, с которыми можно поговорить:" });
            context.KT_Questions.Add(new KT_Question { ID = 84, NumberQuestion = 84, TextQuestion = "Люди иногда считают меня небрежным, хотя и думают, что я приятный  человек:" });
            context.KT_Questions.Add(new KT_Question { ID = 85, NumberQuestion = 85, TextQuestion = "Волнение перед выступлением  в присутствии многих людей  я испытывал:" });
            context.KT_Questions.Add(new KT_Question { ID = 86, NumberQuestion = 86, TextQuestion = "Когда я нахожусь в большой группе людей, то я предпочитаю молчать и предоставляю слово другим:" });
            context.KT_Questions.Add(new KT_Question { ID = 87, NumberQuestion = 87, TextQuestion = "Я предпочитаю читать:" });
            context.KT_Questions.Add(new KT_Question { ID = 88, NumberQuestion = 88, TextQuestion = "Когда люди пытаются мною командовать, то я поступаю как раз наоборот:" });
            context.KT_Questions.Add(new KT_Question { ID = 89, NumberQuestion = 89, TextQuestion = "Начальник или члены моей семьи  критикуют меня только тогда, когда к этому действительно  есть повод:" });
            context.KT_Questions.Add(new KT_Question { ID = 90, NumberQuestion = 90, TextQuestion = "На улицах или в магазинах  мне не нравится, когда некоторые  люди пристально разглядывают  других:" });
            context.KT_Questions.Add(new KT_Question { ID = 91, NumberQuestion = 91, TextQuestion = "Во время длительной поездки  я бы предпочел:" });
            context.KT_Questions.Add(new KT_Question { ID = 92, NumberQuestion = 92, TextQuestion = "В ситуациях, которые могут стать  опасными, я громко разговариваю, хотя это выглядит невежливо  и нарушает спокойствие:" });
            context.KT_Questions.Add(new KT_Question { ID = 93, NumberQuestion = 93, TextQuestion = "Если знакомые плохо обращаются  со мной и показывают свою неприязнь, то:" });
            context.KT_Questions.Add(new KT_Question { ID = 94, NumberQuestion = 94, TextQuestion = "Я смущаюсь, когда меня хвалят  или говорят мне комплименты:" });
            context.KT_Questions.Add(new KT_Question { ID = 95, NumberQuestion = 95, TextQuestion = "Я бы предпочел иметь работу:" });
            context.KT_Questions.Add(new KT_Question { ID = 96, NumberQuestion = 96, TextQuestion = "Чтобы быть информированным, я  предпочитаю получать сведения:" });
            context.KT_Questions.Add(new KT_Question { ID = 97, NumberQuestion = 97, TextQuestion = "Мне нравится принимать активное участие в общественной работе:" });
            context.KT_Questions.Add(new KT_Question { ID = 98, NumberQuestion = 98, TextQuestion = "При выполнении задания я удовлетворяюсь  только тогда, когда должное внимание  будет уделено всем мелочам:" });
            context.KT_Questions.Add(new KT_Question { ID = 99, NumberQuestion = 99, TextQuestion = "Даже самые незначительные неудачи иногда меня слишком раздражают:" });
            context.KT_Questions.Add(new KT_Question { ID = 100, NumberQuestion = 100, TextQuestion = "Сон у меня всегда крепкий, я никогда не хожу и не  разговариваю во сне:" });
            context.KT_Questions.Add(new KT_Question { ID = 101, NumberQuestion = 101, TextQuestion = "Для меня интереснее работа, при  которой:" });
            context.KT_Questions.Add(new KT_Question { ID = 102, NumberQuestion = 102, TextQuestion = "«Размер» так относится к «длине», как «нечестный» к:" });
            context.KT_Questions.Add(new KT_Question { ID = 103, NumberQuestion = 103, TextQuestion = "«АБ» так относится к «ГВ», как «СР» относится к:" });
            context.KT_Questions.Add(new KT_Question { ID = 104, NumberQuestion = 104, TextQuestion = "Когда люди ведут себя неразумно, то я:" });
            context.KT_Questions.Add(new KT_Question { ID = 105, NumberQuestion = 105, TextQuestion = "Если кто-нибудь громко разговаривает, когда я слушаю музыку:" });
            context.KT_Questions.Add(new KT_Question { ID = 106, NumberQuestion = 106, TextQuestion = "Меня лучше характеризовать как:" });
            context.KT_Questions.Add(new KT_Question { ID = 107, NumberQuestion = 107, TextQuestion = "В общественных мероприятиях  я принимаю участие только  тогда, когда это нужно, а в  иных случаях избегаю их:" });
            context.KT_Questions.Add(new KT_Question { ID = 108, NumberQuestion = 108, TextQuestion = "Быть осторожным и не ждать  хорошего лучше, чем быть оптимистом  и всегда ждать успеха:" });
            context.KT_Questions.Add(new KT_Question { ID = 109, NumberQuestion = 109, TextQuestion = "Думая о трудностях в своей  работе, я:" });
            context.KT_Questions.Add(new KT_Question { ID = 110, NumberQuestion = 110, TextQuestion = "Мне легко вступить в контакт  с людьми во время различных  общественных мероприятий:" });
            context.KT_Questions.Add(new KT_Question { ID = 111, NumberQuestion = 111, TextQuestion = "Когда требуется немного дипломатии и умения убедить, чтобы побудить людей что-либо сделать, обычно об этом просят меня:" });
            context.KT_Questions.Add(new KT_Question { ID = 112, NumberQuestion = 112, TextQuestion = "Интересно быть:" });
            context.KT_Questions.Add(new KT_Question { ID = 113, NumberQuestion = 113, TextQuestion = "Если я уверен, что человек  несправедлив или ведет себя  эгоистично, я указываю на это, даже если это связано с  неприятностями:" });
            context.KT_Questions.Add(new KT_Question { ID = 114, NumberQuestion = 114, TextQuestion = "Иногда я говорю глупости ради  шутки, чтобы удивить людей и  посмотреть, что они на это скажут:" });
            context.KT_Questions.Add(new KT_Question { ID = 115, NumberQuestion = 115, TextQuestion = "Мне бы понравилось быть газетным  критиком в разделе драмы, театра, концертов:" });
            context.KT_Questions.Add(new KT_Question { ID = 116, NumberQuestion = 116, TextQuestion = "У меня никогда не бывает  потребности что-нибудь рисовать  или вертеть в руках, ерзать на месте, когда приходится долго сидеть на собрании:" });
            context.KT_Questions.Add(new KT_Question { ID = 117, NumberQuestion = 117, TextQuestion = "Если кто-нибудь говорит мне  что-то неправильное, то я скорее  подумаю:" });
            context.KT_Questions.Add(new KT_Question { ID = 118, NumberQuestion = 118, TextQuestion = "Я чувствую, что мне угрожает  какое-то наказание, даже когда  я ничего плохого не сделал:" });
            context.KT_Questions.Add(new KT_Question { ID = 119, NumberQuestion = 119, TextQuestion = "Мнение о том, что болезнь также  часто бывает от психических, как и от физических факторов, сильно преувеличено:" });
            context.KT_Questions.Add(new KT_Question { ID = 120, NumberQuestion = 120, TextQuestion = "Торжественность и величие традиционных  церемоний следует сохранить:" });
            context.KT_Questions.Add(new KT_Question { ID = 121, NumberQuestion = 121, TextQuestion = "Мысль о том, что люди подумают, будто я веду себя необычно  или странно, меня беспокоит:" });
            context.KT_Questions.Add(new KT_Question { ID = 122, NumberQuestion = 122, TextQuestion = "Выполняя какое-либо дело, я бы  предпочел работать:" });
            context.KT_Questions.Add(new KT_Question { ID = 123, NumberQuestion = 123, TextQuestion = "У меня бывают периоды, когда  мне трудно избавиться от чувства  жалости к себе:" });
            context.KT_Questions.Add(new KT_Question { ID = 124, NumberQuestion = 124, TextQuestion = "Часто я слишком быстро начинаю  сердиться на людей:" });
            context.KT_Questions.Add(new KT_Question { ID = 125, NumberQuestion = 125, TextQuestion = "Я всегда могу без труда  изменить свои старые привычки  и не возвращаться к прежнему:" });
            context.KT_Questions.Add(new KT_Question { ID = 126, NumberQuestion = 126, TextQuestion = "Если бы зарплата была одинаковой, то я предпочел бы быть:" });
            context.KT_Questions.Add(new KT_Question { ID = 127, NumberQuestion = 127, TextQuestion = "«Лучшее» так относится к «наихудшее», как «медленное» к:" });
            context.KT_Questions.Add(new KT_Question { ID = 128, NumberQuestion = 128, TextQuestion = "Каким из приведенных ниже  сочетаний следует продолжить  буквенный ряд РООООРРОООРРР:" });
            context.KT_Questions.Add(new KT_Question { ID = 129, NumberQuestion = 129, TextQuestion = "Когда приходит время осуществить  то, что я планировал и на  что надеялся, я обнаруживаю, что  уже пропало желание делать  это:" });
            context.KT_Questions.Add(new KT_Question { ID = 130, NumberQuestion = 130, TextQuestion = "Большей частью я могу продолжать работать тщательно, не обращая внимания на шум, создаваемый другими:" });
            context.KT_Questions.Add(new KT_Question { ID = 131, NumberQuestion = 131, TextQuestion = "Иногда я говорю посторонним  вещи, кажущиеся мне важными, независимо  от того, спрашивают ли они  об этом:" });
            context.KT_Questions.Add(new KT_Question { ID = 132, NumberQuestion = 132, TextQuestion = "Много свободного времени я  провожу в разговорах с друзьями  о прошлых развлечениях, от которых  я получал удовольствие:" });
            context.KT_Questions.Add(new KT_Question { ID = 133, NumberQuestion = 133, TextQuestion = "Мне нравится устраивать какие-нибудь  смелые рискованные выходки «смеха  ради»:" });
            context.KT_Questions.Add(new KT_Question { ID = 134, NumberQuestion = 134, TextQuestion = "Вид неубранной комнаты очень  раздражает меня:" });
            context.KT_Questions.Add(new KT_Question { ID = 135, NumberQuestion = 135, TextQuestion = "Я считаю себя общительным  открытым человеком:" });
            context.KT_Questions.Add(new KT_Question { ID = 136, NumberQuestion = 136, TextQuestion = "В общении я:" });
            context.KT_Questions.Add(new KT_Question { ID = 137, NumberQuestion = 137, TextQuestion = "Я люблю музыку:" });
            context.KT_Questions.Add(new KT_Question { ID = 138, NumberQuestion = 138, TextQuestion = "Красота поэмы восхищает меня  больше, чем красота хорошо сделанного  оружия:" });
            context.KT_Questions.Add(new KT_Question { ID = 139, NumberQuestion = 139, TextQuestion = "Если мое удачное замечание остается незамеченным окружающими, то я:" });
            context.KT_Questions.Add(new KT_Question { ID = 140, NumberQuestion = 140, TextQuestion = "Мне бы понравилось работать  фотокорреспондентом:" });
            context.KT_Questions.Add(new KT_Question { ID = 141, NumberQuestion = 141, TextQuestion = "Нужно быть осторожным в общении с незнакомыми, так как можно, например, заразиться:" });
            context.KT_Questions.Add(new KT_Question { ID = 142, NumberQuestion = 142, TextQuestion = "При поездке за границу я  бы предпочел быть под руководством  экскурсовода, чем самому планировать  маршрут:" });
            context.KT_Questions.Add(new KT_Question { ID = 143, NumberQuestion = 143, TextQuestion = "Меня справедливо считают упорным и трудолюбивым, но не слишком преуспевающим человеком:" });
            context.KT_Questions.Add(new KT_Question { ID = 144, NumberQuestion = 144, TextQuestion = "Если люди пользуются моим  хорошим отношением в своих  интересах, то я не возмущаюсь  этим и вскоре об этом забываю:" });
            context.KT_Questions.Add(new KT_Question { ID = 145, NumberQuestion = 145, TextQuestion = "Если при обсуждении какого-либо  вопроса среди участников возникает  ожесточенный спор, то я предпочитаю:" });
            context.KT_Questions.Add(new KT_Question { ID = 146, NumberQuestion = 146, TextQuestion = "Я предпочитаю планировать что-либо  самостоятельно, без вмешательства и предложений со стороны других:" });
            context.KT_Questions.Add(new KT_Question { ID = 147, NumberQuestion = 147, TextQuestion = "Иногда чувство зависти влияет  на мои действия:" });
            context.KT_Questions.Add(new KT_Question { ID = 148, NumberQuestion = 148, TextQuestion = "Я твердо верю, что начальник  может быть не всегда прав, но он всегда имеет право  быть начальником:" });
            context.KT_Questions.Add(new KT_Question { ID = 149, NumberQuestion = 149, TextQuestion = "Когда я думаю обо всем, что  еще предстоит сделать, у меня  появляется чувство напряженности:" });
            context.KT_Questions.Add(new KT_Question { ID = 150, NumberQuestion = 150, TextQuestion = "Когда зрители мне что-либо  кричат во время игры, меня  это не трогает:" });
            context.KT_Questions.Add(new KT_Question { ID = 151, NumberQuestion = 151, TextQuestion = "Интереснее быть:" });
            context.KT_Questions.Add(new KT_Question { ID = 152, NumberQuestion = 152, TextQuestion = "Которое из следующих слов  не относится к двум другим:" });
            context.KT_Questions.Add(new KT_Question { ID = 153, NumberQuestion = 153, TextQuestion = "«Пламя» так относится к «жар», как «роза» относится к:" });
            context.KT_Questions.Add(new KT_Question { ID = 154, NumberQuestion = 154, TextQuestion = "У меня бывают яркие сновидения, мешающие мне спать:" });
            context.KT_Questions.Add(new KT_Question { ID = 155, NumberQuestion = 155, TextQuestion = "Если на пути к успеху стоят  серьезные препятствия, я все-таки  предпочитаю рискнуть:" });
            context.KT_Questions.Add(new KT_Question { ID = 156, NumberQuestion = 156, TextQuestion = "Когда я нахожусь в группе  людей, приступающих к какой-то  работе, то само собой получается, что я оказываюсь во главе  их:" });
            context.KT_Questions.Add(new KT_Question { ID = 157, NumberQuestion = 157, TextQuestion = "Мне больше нравится в одежде  спокойная корректность, чем бросающаяся в глаза индивидуальность:" });
            context.KT_Questions.Add(new KT_Question { ID = 158, NumberQuestion = 158, TextQuestion = "Мне больше нравится провести  вечер за спокойным любимым  занятием, чем в оживленной компании:" });
            context.KT_Questions.Add(new KT_Question { ID = 159, NumberQuestion = 159, TextQuestion = "Я не обращаю внимания на  доброжелательные советы других, даже когда эти советы могли бы быть полезными:" });
            context.KT_Questions.Add(new KT_Question { ID = 160, NumberQuestion = 160, TextQuestion = "В своих поступках я всегда  стараюсь придерживаться общепринятых  правил поведения:" });
            context.KT_Questions.Add(new KT_Question { ID = 161, NumberQuestion = 161, TextQuestion = "Мне не очень нравится, когда смотрят, как я работаю:" });
            context.KT_Questions.Add(new KT_Question { ID = 162, NumberQuestion = 162, TextQuestion = "Иногда приходится применять  силу, потому что не всегда  возможно добиться результата  с помощью утверждения:" });
            context.KT_Questions.Add(new KT_Question { ID = 163, NumberQuestion = 163, TextQuestion = "В школе я предпочитал (предпочитаю):" });
            context.KT_Questions.Add(new KT_Question { ID = 164, NumberQuestion = 164, TextQuestion = "Меня иногда огорчало, что обо  мне за глаза отзывались неодобрительно  без всяких к этому причин:" });
            context.KT_Questions.Add(new KT_Question { ID = 165, NumberQuestion = 165, TextQuestion = "Разговор с простыми людьми, которые всегда придерживаются общепринятых правил и традиций:" });
            context.KT_Questions.Add(new KT_Question { ID = 166, NumberQuestion = 166, TextQuestion = "Некоторые вещи настолько раздражают  меня, что предпочитаю вообще  не говорить на эти темы:" });
            context.KT_Questions.Add(new KT_Question { ID = 167, NumberQuestion = 167, TextQuestion = "В воспитании важнее:" });
            context.KT_Questions.Add(new KT_Question { ID = 168, NumberQuestion = 168, TextQuestion = "Люди считают меня положительным, спокойным человеком, которого не трогают превратности судьбы:" });
            context.KT_Questions.Add(new KT_Question { ID = 169, NumberQuestion = 169, TextQuestion = "Я считаю, что общество должно  руководствоваться разумом и  отбросить старые привычки или  ненужные традиции:" });
            context.KT_Questions.Add(new KT_Question { ID = 170, NumberQuestion = 170, TextQuestion = "Думаю, что в современном мире важнее разрешить:" });
            context.KT_Questions.Add(new KT_Question { ID = 171, NumberQuestion = 171, TextQuestion = "Я лучше усваиваю материал:" });
            context.KT_Questions.Add(new KT_Question { ID = 172, NumberQuestion = 172, TextQuestion = "Я предпочитаю идти своим путем  вместо того, чтобы действовать в соответствии с принятыми правилами:" });
            context.KT_Questions.Add(new KT_Question { ID = 173, NumberQuestion = 173, TextQuestion = "Прежде чем выдвигать какой-либо  аргумент, я предпочитаю подождать, пока не буду убежден, что я  прав:" });
            context.KT_Questions.Add(new KT_Question { ID = 174, NumberQuestion = 174, TextQuestion = "Мелочи иногда невыносимо «действуют  мне на нервы», хотя я и понимаю, что они не существенны:" });
            context.KT_Questions.Add(new KT_Question { ID = 175, NumberQuestion = 175, TextQuestion = "Под влиянием момента я редко  говорю вещи, о которых потом  очень сожалею:" });
            context.KT_Questions.Add(new KT_Question { ID = 176, NumberQuestion = 176, TextQuestion = "Если бы меня попросили участвовать  в шефской деятельности, то я  бы:" });
            context.KT_Questions.Add(new KT_Question { ID = 177, NumberQuestion = 177, TextQuestion = "Которое из следующих слов  не относится к двум другим:" });
            context.KT_Questions.Add(new KT_Question { ID = 178, NumberQuestion = 178, TextQuestion = "«Скоро» так относится к «никогда», как «близко» к:" });
            context.KT_Questions.Add(new KT_Question { ID = 179, NumberQuestion = 179, TextQuestion = "Если я невольно нарушил правила  поведения, находясь в обществе, то я вскоре забываю об этом:" });
            context.KT_Questions.Add(new KT_Question { ID = 180, NumberQuestion = 180, TextQuestion = "Меня считают человеком, которому  обычно в голову приходят хорошие идеи, когда нужно разрешить какую-либо проблему:" });
            context.KT_Questions.Add(new KT_Question { ID = 181, NumberQuestion = 181, TextQuestion = "Я способен лучше проявить  себя:" });
            context.KT_Questions.Add(new KT_Question { ID = 182, NumberQuestion = 182, TextQuestion = "Меня считают человеком, полным  энтузиазма:" });
            context.KT_Questions.Add(new KT_Question { ID = 183, NumberQuestion = 183, TextQuestion = "Мне нравится работа, которая  требует перемен, разнообразия, командировок, даже если она связана с  некоторой опасностью:" });
            context.KT_Questions.Add(new KT_Question { ID = 184, NumberQuestion = 184, TextQuestion = "Я довольно требовательный человек  и всегда настаиваю на том, чтобы все делалось по возможности  правильно:" });
            context.KT_Questions.Add(new KT_Question { ID = 185, NumberQuestion = 185, TextQuestion = "Мне нравится работа, требующая  добросовестного отношения, точных  навыков и умений:" });
            context.KT_Questions.Add(new KT_Question { ID = 186, NumberQuestion = 186, TextQuestion = "Я отношусь к типу энергичных  людей, которые всегда заняты:" });
            context.KT_Questions.Add(new KT_Question { ID = 187, NumberQuestion = 187, TextQuestion = "Я уверен в том, что не пропустил  ни одного вопроса и на все  ответил как следует:" });

            context.SaveChanges();

            KT_Question q_1 = context.KT_Questions.FirstOrDefault(q => q.ID == 1);
            context.KT_Answers.Add(new KT_Answer { ID = 1, AnswerNumber = "а", AnswerText = "да", KT_Question = q_1 });
            context.KT_Answers.Add(new KT_Answer { ID = 2, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_1 });
            context.KT_Answers.Add(new KT_Answer { ID = 3, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_1 });

            KT_Question q_2 = context.KT_Questions.FirstOrDefault(q => q.ID == 2);
            context.KT_Answers.Add(new KT_Answer { ID = 4, AnswerNumber = "а", AnswerText = "да", KT_Question = q_2 });
            context.KT_Answers.Add(new KT_Answer { ID = 5, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_2 });
            context.KT_Answers.Add(new KT_Answer { ID = 6, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_2 });

            KT_Question q_3 = context.KT_Questions.FirstOrDefault(q => q.ID == 3);
            context.KT_Answers.Add(new KT_Answer { ID = 7, AnswerNumber = "а", AnswerText = "в обжитом городе", KT_Question = q_3 });
            context.KT_Answers.Add(new KT_Answer { ID = 8, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_3 });
            context.KT_Answers.Add(new KT_Answer { ID = 9, AnswerNumber = "с", AnswerText = "одиноко в глухих лесах", KT_Question = q_3 });

            KT_Question q_4 = context.KT_Questions.FirstOrDefault(q => q.ID == 4);
            context.KT_Answers.Add(new KT_Answer { ID = 10, AnswerNumber = "а", AnswerText = "всегда", KT_Question = q_4 });
            context.KT_Answers.Add(new KT_Answer { ID = 11, AnswerNumber = "в", AnswerText = "обычно", KT_Question = q_4 });
            context.KT_Answers.Add(new KT_Answer { ID = 12, AnswerNumber = "с", AnswerText = "редко", KT_Question = q_4 });

            KT_Question q_5 = context.KT_Questions.FirstOrDefault(q => q.ID == 5);
            context.KT_Answers.Add(new KT_Answer { ID = 13, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_5 });
            context.KT_Answers.Add(new KT_Answer { ID = 14, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_5 });
            context.KT_Answers.Add(new KT_Answer { ID = 15, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_5 });

            KT_Question q_6 = context.KT_Questions.FirstOrDefault(q => q.ID == 6);
            context.KT_Answers.Add(new KT_Answer { ID = 16, AnswerNumber = "а", AnswerText = "да", KT_Question = q_6 });
            context.KT_Answers.Add(new KT_Answer { ID = 17, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_6 });
            context.KT_Answers.Add(new KT_Answer { ID = 18, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_6 });

            KT_Question q_7 = context.KT_Questions.FirstOrDefault(q => q.ID == 7);
            context.KT_Answers.Add(new KT_Answer { ID = 19, AnswerNumber = "а", AnswerText = "обычно", KT_Question = q_7 });
            context.KT_Answers.Add(new KT_Answer { ID = 20, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_7 });
            context.KT_Answers.Add(new KT_Answer { ID = 21, AnswerNumber = "с", AnswerText = "никогда", KT_Question = q_7 });

            KT_Question q_8 = context.KT_Questions.FirstOrDefault(q => q.ID == 8);
            context.KT_Answers.Add(new KT_Answer { ID = 22, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_8 });
            context.KT_Answers.Add(new KT_Answer { ID = 23, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_8 });
            context.KT_Answers.Add(new KT_Answer { ID = 24, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_8 });

            KT_Question q_9 = context.KT_Questions.FirstOrDefault(q => q.ID == 9);
            context.KT_Answers.Add(new KT_Answer { ID = 25, AnswerNumber = "а", AnswerText = "дал бы им возможность договориться самим", KT_Question = q_9 });
            context.KT_Answers.Add(new KT_Answer { ID = 26, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_9 });
            context.KT_Answers.Add(new KT_Answer { ID = 27, AnswerNumber = "с", AnswerText = "рассудил бы их", KT_Question = q_9 });

            KT_Question q_10 = context.KT_Questions.FirstOrDefault(q => q.ID == 10);
            context.KT_Answers.Add(new KT_Answer { ID = 28, AnswerNumber = "а", AnswerText = "с готовностью вступаю в разговор", KT_Question = q_10 });
            context.KT_Answers.Add(new KT_Answer { ID = 29, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_10 });
            context.KT_Answers.Add(new KT_Answer { ID = 30, AnswerNumber = "с", AnswerText = "предпочитаю спокойно оставаться в стороне", KT_Question = q_10 });

            KT_Question q_11 = context.KT_Questions.FirstOrDefault(q => q.ID == 11);
            context.KT_Answers.Add(new KT_Answer { ID = 31, AnswerNumber = "а", AnswerText = "инженером-строителем", KT_Question = q_11 });
            context.KT_Answers.Add(new KT_Answer { ID = 32, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_11 });
            context.KT_Answers.Add(new KT_Answer { ID = 33, AnswerNumber = "с", AnswerText = "драматургом", KT_Question = q_11 });

            KT_Question q_12 = context.KT_Questions.FirstOrDefault(q => q.ID == 12);
            context.KT_Answers.Add(new KT_Answer { ID = 34, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_12 });
            context.KT_Answers.Add(new KT_Answer { ID = 35, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_12 });
            context.KT_Answers.Add(new KT_Answer { ID = 36, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_12 });

            KT_Question q_13 = context.KT_Questions.FirstOrDefault(q => q.ID == 13);
            context.KT_Answers.Add(new KT_Answer { ID = 37, AnswerNumber = "а", AnswerText = "да", KT_Question = q_13 });
            context.KT_Answers.Add(new KT_Answer { ID = 38, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_13 });
            context.KT_Answers.Add(new KT_Answer { ID = 39, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_13 });

            KT_Question q_14 = context.KT_Questions.FirstOrDefault(q => q.ID == 14);
            context.KT_Answers.Add(new KT_Answer { ID = 40, AnswerNumber = "а", AnswerText = "да", KT_Question = q_14 });
            context.KT_Answers.Add(new KT_Answer { ID = 41, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_14 });
            context.KT_Answers.Add(new KT_Answer { ID = 42, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_14 });

            KT_Question q_15 = context.KT_Questions.FirstOrDefault(q => q.ID == 15);
            context.KT_Answers.Add(new KT_Answer { ID = 43, AnswerNumber = "а", AnswerText = "согласен", KT_Question = q_15 });
            context.KT_Answers.Add(new KT_Answer { ID = 44, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_15 });
            context.KT_Answers.Add(new KT_Answer { ID = 45, AnswerNumber = "с", AnswerText = "не согласен", KT_Question = q_15 });

            KT_Question q_16 = context.KT_Questions.FirstOrDefault(q => q.ID == 16);
            context.KT_Answers.Add(new KT_Answer { ID = 46, AnswerNumber = "а", AnswerText = "согласен", KT_Question = q_16 });
            context.KT_Answers.Add(new KT_Answer { ID = 47, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_16 });
            context.KT_Answers.Add(new KT_Answer { ID = 48, AnswerNumber = "с", AnswerText = "не согласен", KT_Question = q_16 });

            KT_Question q_17 = context.KT_Questions.FirstOrDefault(q => q.ID == 17);
            context.KT_Answers.Add(new KT_Answer { ID = 49, AnswerNumber = "а", AnswerText = "только если это необходимо", KT_Question = q_17 });
            context.KT_Answers.Add(new KT_Answer { ID = 50, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_17 });
            context.KT_Answers.Add(new KT_Answer { ID = 51, AnswerNumber = "с", AnswerText = "охотно, когда представится возможность", KT_Question = q_17 });

            KT_Question q_18 = context.KT_Questions.FirstOrDefault(q => q.ID == 18);
            context.KT_Answers.Add(new KT_Answer { ID = 52, AnswerNumber = "а", AnswerText = "да", KT_Question = q_18 });
            context.KT_Answers.Add(new KT_Answer { ID = 53, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_18 });
            context.KT_Answers.Add(new KT_Answer { ID = 54, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_18 });

            KT_Question q_19 = context.KT_Questions.FirstOrDefault(q => q.ID == 19);
            context.KT_Answers.Add(new KT_Answer { ID = 55, AnswerNumber = "а", AnswerText = "не испытываю чувства вины", KT_Question = q_19 });
            context.KT_Answers.Add(new KT_Answer { ID = 56, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_19 });
            context.KT_Answers.Add(new KT_Answer { ID = 57, AnswerNumber = "с", AnswerText = "все же чувствую себя немного виноватым", KT_Question = q_19 });

            KT_Question q_20 = context.KT_Questions.FirstOrDefault(q => q.ID == 20);
            context.KT_Answers.Add(new KT_Answer { ID = 58, AnswerNumber = "а", AnswerText = "да", KT_Question = q_20 });
            context.KT_Answers.Add(new KT_Answer { ID = 59, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_20 });
            context.KT_Answers.Add(new KT_Answer { ID = 60, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_20 });

            KT_Question q_21 = context.KT_Questions.FirstOrDefault(q => q.ID == 21);
            context.KT_Answers.Add(new KT_Answer { ID = 61, AnswerNumber = "а", AnswerText = "сердце", KT_Question = q_21 });
            context.KT_Answers.Add(new KT_Answer { ID = 62, AnswerNumber = "в", AnswerText = "сердце и разум в равной степени", KT_Question = q_21 });
            context.KT_Answers.Add(new KT_Answer { ID = 63, AnswerNumber = "с", AnswerText = "разум", KT_Question = q_21 });

            KT_Question q_22 = context.KT_Questions.FirstOrDefault(q => q.ID == 22);
            context.KT_Answers.Add(new KT_Answer { ID = 64, AnswerNumber = "а", AnswerText = "да", KT_Question = q_22 });
            context.KT_Answers.Add(new KT_Answer { ID = 65, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_22 });
            context.KT_Answers.Add(new KT_Answer { ID = 66, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_22 });

            KT_Question q_23 = context.KT_Questions.FirstOrDefault(q => q.ID == 23);
            context.KT_Answers.Add(new KT_Answer { ID = 67, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_23 });
            context.KT_Answers.Add(new KT_Answer { ID = 68, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_23 });
            context.KT_Answers.Add(new KT_Answer { ID = 69, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_23 });

            KT_Question q_24 = context.KT_Questions.FirstOrDefault(q => q.ID == 24);
            context.KT_Answers.Add(new KT_Answer { ID = 70, AnswerNumber = "а", AnswerText = "высказывать свои мысли так, как они приходят мне в голову", KT_Question = q_24 });
            context.KT_Answers.Add(new KT_Answer { ID = 71, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_24 });
            context.KT_Answers.Add(new KT_Answer { ID = 72, AnswerNumber = "с", AnswerText = "сначала сформулировать получше свои мысли", KT_Question = q_24 });

            KT_Question q_25 = context.KT_Questions.FirstOrDefault(q => q.ID == 25);
            context.KT_Answers.Add(new KT_Answer { ID = 73, AnswerNumber = "а", AnswerText = "да", KT_Question = q_25 });
            context.KT_Answers.Add(new KT_Answer { ID = 74, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_25 });
            context.KT_Answers.Add(new KT_Answer { ID = 75, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_25 });

            KT_Question q_26 = context.KT_Questions.FirstOrDefault(q => q.ID == 26);
            context.KT_Answers.Add(new KT_Answer { ID = 76, AnswerNumber = "а", AnswerText = "плотником или поваром", KT_Question = q_26 });
            context.KT_Answers.Add(new KT_Answer { ID = 77, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_26 });
            context.KT_Answers.Add(new KT_Answer { ID = 78, AnswerNumber = "с", AnswerText = "официантом в хорошем ресторане", KT_Question = q_26 });

            KT_Question q_27 = context.KT_Questions.FirstOrDefault(q => q.ID == 27);
            context.KT_Answers.Add(new KT_Answer { ID = 79, AnswerNumber = "а", AnswerText = "очень редко", KT_Question = q_27 });
            context.KT_Answers.Add(new KT_Answer { ID = 80, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_27 });
            context.KT_Answers.Add(new KT_Answer { ID = 81, AnswerNumber = "с", AnswerText = "много раз", KT_Question = q_27 });

            KT_Question q_28 = context.KT_Questions.FirstOrDefault(q => q.ID == 28);
            context.KT_Answers.Add(new KT_Answer { ID = 82, AnswerNumber = "а", AnswerText = "«острый»", KT_Question = q_28 });
            context.KT_Answers.Add(new KT_Answer { ID = 83, AnswerNumber = "в", AnswerText = "«резать»", KT_Question = q_28 });
            context.KT_Answers.Add(new KT_Answer { ID = 84, AnswerNumber = "с", AnswerText = "«указывать»", KT_Question = q_28 });

            KT_Question q_29 = context.KT_Questions.FirstOrDefault(q => q.ID == 29);
            context.KT_Answers.Add(new KT_Answer { ID = 85, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_29 });
            context.KT_Answers.Add(new KT_Answer { ID = 86, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_29 });
            context.KT_Answers.Add(new KT_Answer { ID = 87, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_29 });

            KT_Question q_30 = context.KT_Questions.FirstOrDefault(q => q.ID == 30);
            context.KT_Answers.Add(new KT_Answer { ID = 88, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_30 });
            context.KT_Answers.Add(new KT_Answer { ID = 89, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_30 });
            context.KT_Answers.Add(new KT_Answer { ID = 90, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_30 });

            KT_Question q_31 = context.KT_Questions.FirstOrDefault(q => q.ID == 31);
            context.KT_Answers.Add(new KT_Answer { ID = 91, AnswerNumber = "а", AnswerText = "только после основательного обсуждения", KT_Question = q_31 });
            context.KT_Answers.Add(new KT_Answer { ID = 92, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_31 });
            context.KT_Answers.Add(new KT_Answer { ID = 93, AnswerNumber = "с", AnswerText = "как можно скорее", KT_Question = q_31 });

            KT_Question q_32 = context.KT_Questions.FirstOrDefault(q => q.ID == 32);
            context.KT_Answers.Add(new KT_Answer { ID = 94, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_32 });
            context.KT_Answers.Add(new KT_Answer { ID = 95, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_32 });
            context.KT_Answers.Add(new KT_Answer { ID = 96, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_32 });

            KT_Question q_33 = context.KT_Questions.FirstOrDefault(q => q.ID == 33);
            context.KT_Answers.Add(new KT_Answer { ID = 97, AnswerNumber = "а", AnswerText = "да", KT_Question = q_33 });
            context.KT_Answers.Add(new KT_Answer { ID = 98, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_33 });
            context.KT_Answers.Add(new KT_Answer { ID = 99, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_33 });

            KT_Question q_34 = context.KT_Questions.FirstOrDefault(q => q.ID == 34);
            context.KT_Answers.Add(new KT_Answer { ID = 100, AnswerNumber = "а", AnswerText = "принимаю их такими, как они есть", KT_Question = q_34 });
            context.KT_Answers.Add(new KT_Answer { ID = 101, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_34 });
            context.KT_Answers.Add(new KT_Answer { ID = 102, AnswerNumber = "с", AnswerText = "испытываю отвращение и возмущение", KT_Question = q_34 });

            KT_Question q_35 = context.KT_Questions.FirstOrDefault(q => q.ID == 35);
            context.KT_Answers.Add(new KT_Answer { ID = 103, AnswerNumber = "а", AnswerText = "да", KT_Question = q_35 });
            context.KT_Answers.Add(new KT_Answer { ID = 104, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_35 });
            context.KT_Answers.Add(new KT_Answer { ID = 105, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_35 });

            KT_Question q_36 = context.KT_Questions.FirstOrDefault(q => q.ID == 36);
            context.KT_Answers.Add(new KT_Answer { ID = 106, AnswerNumber = "а", AnswerText = "да", KT_Question = q_36 });
            context.KT_Answers.Add(new KT_Answer { ID = 107, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_36 });
            context.KT_Answers.Add(new KT_Answer { ID = 108, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_36 });

            KT_Question q_37 = context.KT_Questions.FirstOrDefault(q => q.ID == 37);
            context.KT_Answers.Add(new KT_Answer { ID = 109, AnswerNumber = "а", AnswerText = "заниматься музыкой, пением", KT_Question = q_37 });
            context.KT_Answers.Add(new KT_Answer { ID = 110, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_37 });
            context.KT_Answers.Add(new KT_Answer { ID = 111, AnswerNumber = "с", AnswerText = "выпиливать и мастерить что-либо", KT_Question = q_37 });

            KT_Question q_38 = context.KT_Questions.FirstOrDefault(q => q.ID == 38);
            context.KT_Answers.Add(new KT_Answer { ID = 112, AnswerNumber = "а", AnswerText = "да", KT_Question = q_38 });
            context.KT_Answers.Add(new KT_Answer { ID = 113, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_38 });
            context.KT_Answers.Add(new KT_Answer { ID = 114, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_38 });

            KT_Question q_39 = context.KT_Questions.FirstOrDefault(q => q.ID == 39);
            context.KT_Answers.Add(new KT_Answer { ID = 115, AnswerNumber = "а", AnswerText = "помогали детям развивать свои чувства", KT_Question = q_39 });
            context.KT_Answers.Add(new KT_Answer { ID = 116, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_39 });
            context.KT_Answers.Add(new KT_Answer { ID = 117, AnswerNumber = "с", AnswerText = "обучали детей сдерживать свои чувства", KT_Question = q_39 });

            KT_Question q_40 = context.KT_Questions.FirstOrDefault(q => q.ID == 40);
            context.KT_Answers.Add(new KT_Answer { ID = 118, AnswerNumber = "а", AnswerText = "постараться улучшить организацию работы", KT_Question = q_40 });
            context.KT_Answers.Add(new KT_Answer { ID = 119, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_40 });
            context.KT_Answers.Add(new KT_Answer { ID = 120, AnswerNumber = "с", AnswerText = "следить за результатами и соблюдением правил", KT_Question = q_40 });

            KT_Question q_41 = context.KT_Questions.FirstOrDefault(q => q.ID == 41);
            context.KT_Answers.Add(new KT_Answer { ID = 121, AnswerNumber = "а", AnswerText = "да", KT_Question = q_41 });
            context.KT_Answers.Add(new KT_Answer { ID = 122, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_41 });
            context.KT_Answers.Add(new KT_Answer { ID = 123, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_41 });

            KT_Question q_42 = context.KT_Questions.FirstOrDefault(q => q.ID == 42);
            context.KT_Answers.Add(new KT_Answer { ID = 124, AnswerNumber = "а", AnswerText = "да", KT_Question = q_42 });
            context.KT_Answers.Add(new KT_Answer { ID = 125, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_42 });
            context.KT_Answers.Add(new KT_Answer { ID = 126, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_42 });

            KT_Question q_43 = context.KT_Questions.FirstOrDefault(q => q.ID == 43);
            context.KT_Answers.Add(new KT_Answer { ID = 127, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_43 });
            context.KT_Answers.Add(new KT_Answer { ID = 128, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_43 });
            context.KT_Answers.Add(new KT_Answer { ID = 129, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_43 });

            KT_Question q_44 = context.KT_Questions.FirstOrDefault(q => q.ID == 44);
            context.KT_Answers.Add(new KT_Answer { ID = 130, AnswerNumber = "а", AnswerText = "пользуюсь случаем, чтобы попросить о чем-то нужном мне", KT_Question = q_44 });
            context.KT_Answers.Add(new KT_Answer { ID = 131, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_44 });
            context.KT_Answers.Add(new KT_Answer { ID = 132, AnswerNumber = "с", AnswerText = "боюсь, что это связано с какой-нибудь оплошностью в моей работе", KT_Question = q_44 });

            KT_Question q_45 = context.KT_Questions.FirstOrDefault(q => q.ID == 45);
            context.KT_Answers.Add(new KT_Answer { ID = 133, AnswerNumber = "а", AnswerText = "больше спокойных, солидных людей", KT_Question = q_45 });
            context.KT_Answers.Add(new KT_Answer { ID = 134, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_45 });
            context.KT_Answers.Add(new KT_Answer { ID = 135, AnswerNumber = "с", AnswerText = "больше «идеалистов», планирующих лучшее будущее", KT_Question = q_45 });

            KT_Question q_46 = context.KT_Questions.FirstOrDefault(q => q.ID == 46);
            context.KT_Answers.Add(new KT_Answer { ID = 136, AnswerNumber = "а", AnswerText = "да", KT_Question = q_46 });
            context.KT_Answers.Add(new KT_Answer { ID = 137, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_46 });
            context.KT_Answers.Add(new KT_Answer { ID = 138, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_46 });

            KT_Question q_47 = context.KT_Questions.FirstOrDefault(q => q.ID == 47);
            context.KT_Answers.Add(new KT_Answer { ID = 139, AnswerNumber = "а", AnswerText = "иногда", KT_Question = q_47 });
            context.KT_Answers.Add(new KT_Answer { ID = 140, AnswerNumber = "в", AnswerText = "довольно часто", KT_Question = q_47 });
            context.KT_Answers.Add(new KT_Answer { ID = 141, AnswerNumber = "с", AnswerText = "многократно", KT_Question = q_47 });

            KT_Question q_48 = context.KT_Questions.FirstOrDefault(q => q.ID == 48);
            context.KT_Answers.Add(new KT_Answer { ID = 142, AnswerNumber = "а", AnswerText = "да", KT_Question = q_48 });
            context.KT_Answers.Add(new KT_Answer { ID = 143, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_48 });
            context.KT_Answers.Add(new KT_Answer { ID = 144, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_48 });

            KT_Question q_49 = context.KT_Questions.FirstOrDefault(q => q.ID == 49);
            context.KT_Answers.Add(new KT_Answer { ID = 145, AnswerNumber = "а", AnswerText = "да", KT_Question = q_49 });
            context.KT_Answers.Add(new KT_Answer { ID = 146, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_49 });
            context.KT_Answers.Add(new KT_Answer { ID = 147, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_49 });

            KT_Question q_50 = context.KT_Questions.FirstOrDefault(q => q.ID == 50);
            context.KT_Answers.Add(new KT_Answer { ID = 148, AnswerNumber = "а", AnswerText = "да", KT_Question = q_50 });
            context.KT_Answers.Add(new KT_Answer { ID = 149, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_50 });
            context.KT_Answers.Add(new KT_Answer { ID = 150, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_50 });

            KT_Question q_51 = context.KT_Questions.FirstOrDefault(q => q.ID == 51);
            context.KT_Answers.Add(new KT_Answer { ID = 151, AnswerNumber = "а", AnswerText = "лесником", KT_Question = q_51 });
            context.KT_Answers.Add(new KT_Answer { ID = 152, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_51 });
            context.KT_Answers.Add(new KT_Answer { ID = 153, AnswerNumber = "с", AnswerText = "учителем средней школы", KT_Question = q_51 });

            KT_Question q_52 = context.KT_Questions.FirstOrDefault(q => q.ID == 52);
            context.KT_Answers.Add(new KT_Answer { ID = 154, AnswerNumber = "а", AnswerText = "люблю делать подарки", KT_Question = q_52 });
            context.KT_Answers.Add(new KT_Answer { ID = 155, AnswerNumber = "в", AnswerText = "неопределенно", KT_Question = q_52 });
            context.KT_Answers.Add(new KT_Answer { ID = 156, AnswerNumber = "с", AnswerText = "считаю, что делать подарки – довольно неприятная вещь", KT_Question = q_52 });

            KT_Question q_53 = context.KT_Questions.FirstOrDefault(q => q.ID == 53);
            context.KT_Answers.Add(new KT_Answer { ID = 157, AnswerNumber = "а", AnswerText = "«улыбка»", KT_Question = q_53 });
            context.KT_Answers.Add(new KT_Answer { ID = 158, AnswerNumber = "в", AnswerText = "«успех»", KT_Question = q_53 });
            context.KT_Answers.Add(new KT_Answer { ID = 159, AnswerNumber = "с", AnswerText = "«счастливый»", KT_Question = q_53 });

            KT_Question q_54 = context.KT_Questions.FirstOrDefault(q => q.ID == 54);
            context.KT_Answers.Add(new KT_Answer { ID = 160, AnswerNumber = "а", AnswerText = "свеча", KT_Question = q_54 });
            context.KT_Answers.Add(new KT_Answer { ID = 161, AnswerNumber = "в", AnswerText = "луна", KT_Question = q_54 });
            context.KT_Answers.Add(new KT_Answer { ID = 162, AnswerNumber = "с", AnswerText = "электрический свет", KT_Question = q_54 });

            KT_Question q_55 = context.KT_Questions.FirstOrDefault(q => q.ID == 55);
            context.KT_Answers.Add(new KT_Answer { ID = 163, AnswerNumber = "а", AnswerText = "очень редко", KT_Question = q_55 });
            context.KT_Answers.Add(new KT_Answer { ID = 164, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_55 });
            context.KT_Answers.Add(new KT_Answer { ID = 165, AnswerNumber = "с", AnswerText = "довольно часто", KT_Question = q_55 });

            KT_Question q_56 = context.KT_Questions.FirstOrDefault(q => q.ID == 56);
            context.KT_Answers.Add(new KT_Answer { ID = 166, AnswerNumber = "а", AnswerText = "да", KT_Question = q_56 });
            context.KT_Answers.Add(new KT_Answer { ID = 167, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_56 });
            context.KT_Answers.Add(new KT_Answer { ID = 168, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_56 });

            KT_Question q_57 = context.KT_Questions.FirstOrDefault(q => q.ID == 57);
            context.KT_Answers.Add(new KT_Answer { ID = 169, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_57 });
            context.KT_Answers.Add(new KT_Answer { ID = 170, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_57 });
            context.KT_Answers.Add(new KT_Answer { ID = 171, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_57 });

            KT_Question q_58 = context.KT_Questions.FirstOrDefault(q => q.ID == 58);
            context.KT_Answers.Add(new KT_Answer { ID = 172, AnswerNumber = "а", AnswerText = "чаще, чем раз в неделю (те чаще, чем большинство", KT_Question = q_58 });
            context.KT_Answers.Add(new KT_Answer { ID = 173, AnswerNumber = "в", AnswerText = "примерно раз в неделю (те как большинство", KT_Question = q_58 });
            context.KT_Answers.Add(new KT_Answer { ID = 174, AnswerNumber = "с", AnswerText = "реже, чем раз в неделю (те реже, чем большинство", KT_Question = q_58 });

            KT_Question q_59 = context.KT_Questions.FirstOrDefault(q => q.ID == 59);
            context.KT_Answers.Add(new KT_Answer { ID = 175, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_59 });
            context.KT_Answers.Add(new KT_Answer { ID = 176, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_59 });
            context.KT_Answers.Add(new KT_Answer { ID = 177, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_59 });

            KT_Question q_60 = context.KT_Questions.FirstOrDefault(q => q.ID == 60);
            context.KT_Answers.Add(new KT_Answer { ID = 178, AnswerNumber = "а", AnswerText = "да", KT_Question = q_60 });
            context.KT_Answers.Add(new KT_Answer { ID = 179, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_60 });
            context.KT_Answers.Add(new KT_Answer { ID = 180, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_60 });

            KT_Question q_61 = context.KT_Questions.FirstOrDefault(q => q.ID == 61);
            context.KT_Answers.Add(new KT_Answer { ID = 181, AnswerNumber = "а", AnswerText = "да", KT_Question = q_61 });
            context.KT_Answers.Add(new KT_Answer { ID = 182, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_61 });
            context.KT_Answers.Add(new KT_Answer { ID = 183, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_61 });

            KT_Question q_62 = context.KT_Questions.FirstOrDefault(q => q.ID == 62);
            context.KT_Answers.Add(new KT_Answer { ID = 184, AnswerNumber = "а", AnswerText = "да", KT_Question = q_62 });
            context.KT_Answers.Add(new KT_Answer { ID = 185, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_62 });
            context.KT_Answers.Add(new KT_Answer { ID = 186, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_62 });

            KT_Question q_63 = context.KT_Questions.FirstOrDefault(q => q.ID == 63);
            context.KT_Answers.Add(new KT_Answer { ID = 187, AnswerNumber = "а", AnswerText = "постараюсь его успокоить", KT_Question = q_63 });
            context.KT_Answers.Add(new KT_Answer { ID = 188, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_63 });
            context.KT_Answers.Add(new KT_Answer { ID = 189, AnswerNumber = "с", AnswerText = "раздражаюсь", KT_Question = q_63 });

            KT_Question q_64 = context.KT_Questions.FirstOrDefault(q => q.ID == 64);
            context.KT_Answers.Add(new KT_Answer { ID = 190, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_64 });
            context.KT_Answers.Add(new KT_Answer { ID = 191, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_64 });
            context.KT_Answers.Add(new KT_Answer { ID = 192, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_64 });

            KT_Question q_65 = context.KT_Questions.FirstOrDefault(q => q.ID == 65);
            context.KT_Answers.Add(new KT_Answer { ID = 193, AnswerNumber = "а", AnswerText = "да", KT_Question = q_65 });
            context.KT_Answers.Add(new KT_Answer { ID = 194, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_65 });
            context.KT_Answers.Add(new KT_Answer { ID = 195, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_65 });

            KT_Question q_66 = context.KT_Questions.FirstOrDefault(q => q.ID == 66);
            context.KT_Answers.Add(new KT_Answer { ID = 196, AnswerNumber = "а", AnswerText = "да", KT_Question = q_66 });
            context.KT_Answers.Add(new KT_Answer { ID = 197, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_66 });
            context.KT_Answers.Add(new KT_Answer { ID = 198, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_66 });

            KT_Question q_67 = context.KT_Questions.FirstOrDefault(q => q.ID == 67);
            context.KT_Answers.Add(new KT_Answer { ID = 199, AnswerNumber = "а", AnswerText = "да", KT_Question = q_67 });
            context.KT_Answers.Add(new KT_Answer { ID = 200, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_67 });
            context.KT_Answers.Add(new KT_Answer { ID = 201, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_67 });

            KT_Question q_68 = context.KT_Questions.FirstOrDefault(q => q.ID == 68);
            context.KT_Answers.Add(new KT_Answer { ID = 202, AnswerNumber = "а", AnswerText = "очень редко", KT_Question = q_68 });
            context.KT_Answers.Add(new KT_Answer { ID = 203, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_68 });
            context.KT_Answers.Add(new KT_Answer { ID = 204, AnswerNumber = "с", AnswerText = "довольно часто", KT_Question = q_68 });

            KT_Question q_69 = context.KT_Questions.FirstOrDefault(q => q.ID == 69);
            context.KT_Answers.Add(new KT_Answer { ID = 205, AnswerNumber = "а", AnswerText = "да", KT_Question = q_69 });
            context.KT_Answers.Add(new KT_Answer { ID = 206, AnswerNumber = "в", AnswerText = "нечто среднее,", KT_Question = q_69 });
            context.KT_Answers.Add(new KT_Answer { ID = 207, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_69 });

            KT_Question q_70 = context.KT_Questions.FirstOrDefault(q => q.ID == 70);
            context.KT_Answers.Add(new KT_Answer { ID = 208, AnswerNumber = "а", AnswerText = "оставался при своем мнении", KT_Question = q_70 });
            context.KT_Answers.Add(new KT_Answer { ID = 209, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_70 });
            context.KT_Answers.Add(new KT_Answer { ID = 210, AnswerNumber = "с", AnswerText = "соглашался с их авторитетом", KT_Question = q_70 });

            KT_Question q_71 = context.KT_Questions.FirstOrDefault(q => q.ID == 71);
            context.KT_Answers.Add(new KT_Answer { ID = 211, AnswerNumber = "а", AnswerText = "да", KT_Question = q_71 });
            context.KT_Answers.Add(new KT_Answer { ID = 212, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_71 });
            context.KT_Answers.Add(new KT_Answer { ID = 213, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_71 });

            KT_Question q_72 = context.KT_Questions.FirstOrDefault(q => q.ID == 72);
            context.KT_Answers.Add(new KT_Answer { ID = 214, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_72 });
            context.KT_Answers.Add(new KT_Answer { ID = 215, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_72 });
            context.KT_Answers.Add(new KT_Answer { ID = 216, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_72 });

            KT_Question q_73 = context.KT_Questions.FirstOrDefault(q => q.ID == 73);
            context.KT_Answers.Add(new KT_Answer { ID = 217, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_73 });
            context.KT_Answers.Add(new KT_Answer { ID = 218, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_73 });
            context.KT_Answers.Add(new KT_Answer { ID = 219, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_73 });

            KT_Question q_74 = context.KT_Questions.FirstOrDefault(q => q.ID == 74);
            context.KT_Answers.Add(new KT_Answer { ID = 220, AnswerNumber = "а", AnswerText = "часто", KT_Question = q_74 });
            context.KT_Answers.Add(new KT_Answer { ID = 221, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_74 });
            context.KT_Answers.Add(new KT_Answer { ID = 222, AnswerNumber = "с", AnswerText = "никогда", KT_Question = q_74 });

            KT_Question q_75 = context.KT_Questions.FirstOrDefault(q => q.ID == 75);
            context.KT_Answers.Add(new KT_Answer { ID = 223, AnswerNumber = "а", AnswerText = "да", KT_Question = q_75 });
            context.KT_Answers.Add(new KT_Answer { ID = 224, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_75 });
            context.KT_Answers.Add(new KT_Answer { ID = 225, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_75 });

            KT_Question q_76 = context.KT_Questions.FirstOrDefault(q => q.ID == 76);
            context.KT_Answers.Add(new KT_Answer { ID = 226, AnswerNumber = "а", AnswerText = "разрабатывать его в лаборатории", KT_Question = q_76 });
            context.KT_Answers.Add(new KT_Answer { ID = 227, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_76 });
            context.KT_Answers.Add(new KT_Answer { ID = 228, AnswerNumber = "с", AnswerText = "заниматься его практической реализацией", KT_Question = q_76 });

            KT_Question q_77 = context.KT_Questions.FirstOrDefault(q => q.ID == 77);
            context.KT_Answers.Add(new KT_Answer { ID = 229, AnswerNumber = "а", AnswerText = "«смелый»", KT_Question = q_77 });
            context.KT_Answers.Add(new KT_Answer { ID = 230, AnswerNumber = "в", AnswerText = "«тревожный»", KT_Question = q_77 });
            context.KT_Answers.Add(new KT_Answer { ID = 231, AnswerNumber = "с", AnswerText = "«ужасный»", KT_Question = q_77 });

            KT_Question q_78 = context.KT_Questions.FirstOrDefault(q => q.ID == 78);
            context.KT_Answers.Add(new KT_Answer { ID = 232, AnswerNumber = "а", AnswerText = "3/7", KT_Question = q_78 });
            context.KT_Answers.Add(new KT_Answer { ID = 233, AnswerNumber = "в", AnswerText = "3/9", KT_Question = q_78 });
            context.KT_Answers.Add(new KT_Answer { ID = 234, AnswerNumber = "с", AnswerText = "3/11", KT_Question = q_78 });

            KT_Question q_79 = context.KT_Questions.FirstOrDefault(q => q.ID == 79);
            context.KT_Answers.Add(new KT_Answer { ID = 235, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_79 });
            context.KT_Answers.Add(new KT_Answer { ID = 236, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_79 });
            context.KT_Answers.Add(new KT_Answer { ID = 237, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_79 });

            KT_Question q_80 = context.KT_Questions.FirstOrDefault(q => q.ID == 80);
            context.KT_Answers.Add(new KT_Answer { ID = 238, AnswerNumber = "а", AnswerText = "часто", KT_Question = q_80 });
            context.KT_Answers.Add(new KT_Answer { ID = 239, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_80 });
            context.KT_Answers.Add(new KT_Answer { ID = 240, AnswerNumber = "с", AnswerText = "никогда", KT_Question = q_80 });

            KT_Question q_81 = context.KT_Questions.FirstOrDefault(q => q.ID == 81);
            context.KT_Answers.Add(new KT_Answer { ID = 241, AnswerNumber = "а", AnswerText = "да", KT_Question = q_81 });
            context.KT_Answers.Add(new KT_Answer { ID = 242, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_81 });
            context.KT_Answers.Add(new KT_Answer { ID = 243, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_81 });

            KT_Question q_82 = context.KT_Questions.FirstOrDefault(q => q.ID == 82);
            context.KT_Answers.Add(new KT_Answer { ID = 244, AnswerNumber = "а", AnswerText = "да", KT_Question = q_82 });
            context.KT_Answers.Add(new KT_Answer { ID = 245, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_82 });
            context.KT_Answers.Add(new KT_Answer { ID = 246, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_82 });

            KT_Question q_83 = context.KT_Questions.FirstOrDefault(q => q.ID == 83);
            context.KT_Answers.Add(new KT_Answer { ID = 247, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_83 });
            context.KT_Answers.Add(new KT_Answer { ID = 248, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_83 });
            context.KT_Answers.Add(new KT_Answer { ID = 249, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_83 });

            KT_Question q_84 = context.KT_Questions.FirstOrDefault(q => q.ID == 84);
            context.KT_Answers.Add(new KT_Answer { ID = 250, AnswerNumber = "а", AnswerText = "да", KT_Question = q_84 });
            context.KT_Answers.Add(new KT_Answer { ID = 251, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_84 });
            context.KT_Answers.Add(new KT_Answer { ID = 252, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_84 });

            KT_Question q_85 = context.KT_Questions.FirstOrDefault(q => q.ID == 85);
            context.KT_Answers.Add(new KT_Answer { ID = 253, AnswerNumber = "а", AnswerText = "довольно часто", KT_Question = q_85 });
            context.KT_Answers.Add(new KT_Answer { ID = 254, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_85 });
            context.KT_Answers.Add(new KT_Answer { ID = 255, AnswerNumber = "с", AnswerText = "почти никогда", KT_Question = q_85 });

            KT_Question q_86 = context.KT_Questions.FirstOrDefault(q => q.ID == 86);
            context.KT_Answers.Add(new KT_Answer { ID = 256, AnswerNumber = "а", AnswerText = "да", KT_Question = q_86 });
            context.KT_Answers.Add(new KT_Answer { ID = 257, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_86 });
            context.KT_Answers.Add(new KT_Answer { ID = 258, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_86 });

            KT_Question q_87 = context.KT_Questions.FirstOrDefault(q => q.ID == 87);
            context.KT_Answers.Add(new KT_Answer { ID = 259, AnswerNumber = "а", AnswerText = "реалистические описания военных и политических сражений", KT_Question = q_87 });
            context.KT_Answers.Add(new KT_Answer { ID = 260, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_87 });
            context.KT_Answers.Add(new KT_Answer { ID = 261, AnswerNumber = "с", AnswerText = "роман, где много чувств и воображения", KT_Question = q_87 });

            KT_Question q_88 = context.KT_Questions.FirstOrDefault(q => q.ID == 88);
            context.KT_Answers.Add(new KT_Answer { ID = 262, AnswerNumber = "а", AnswerText = "да", KT_Question = q_88 });
            context.KT_Answers.Add(new KT_Answer { ID = 263, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_88 });
            context.KT_Answers.Add(new KT_Answer { ID = 264, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_88 });

            KT_Question q_89 = context.KT_Questions.FirstOrDefault(q => q.ID == 89);
            context.KT_Answers.Add(new KT_Answer { ID = 265, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_89 });
            context.KT_Answers.Add(new KT_Answer { ID = 266, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_89 });
            context.KT_Answers.Add(new KT_Answer { ID = 267, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_89 });

            KT_Question q_90 = context.KT_Questions.FirstOrDefault(q => q.ID == 90);
            context.KT_Answers.Add(new KT_Answer { ID = 268, AnswerNumber = "а", AnswerText = "да", KT_Question = q_90 });
            context.KT_Answers.Add(new KT_Answer { ID = 269, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_90 });
            context.KT_Answers.Add(new KT_Answer { ID = 270, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_90 });

            KT_Question q_91 = context.KT_Questions.FirstOrDefault(q => q.ID == 91);
            context.KT_Answers.Add(new KT_Answer { ID = 271, AnswerNumber = "а", AnswerText = "читать что-нибудь серьезное, но интересное", KT_Question = q_91 });
            context.KT_Answers.Add(new KT_Answer { ID = 272, AnswerNumber = "в", AnswerText = "неопределенно", KT_Question = q_91 });
            context.KT_Answers.Add(new KT_Answer { ID = 273, AnswerNumber = "с", AnswerText = "провести время, беседуя с кем-нибудь из пассажиров", KT_Question = q_91 });

            KT_Question q_92 = context.KT_Questions.FirstOrDefault(q => q.ID == 92);
            context.KT_Answers.Add(new KT_Answer { ID = 274, AnswerNumber = "а", AnswerText = "да", KT_Question = q_92 });
            context.KT_Answers.Add(new KT_Answer { ID = 275, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_92 });
            context.KT_Answers.Add(new KT_Answer { ID = 276, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_92 });

            KT_Question q_93 = context.KT_Questions.FirstOrDefault(q => q.ID == 93);
            context.KT_Answers.Add(new KT_Answer { ID = 277, AnswerNumber = "а", AnswerText = "меня это совершенно не трогает", KT_Question = q_93 });
            context.KT_Answers.Add(new KT_Answer { ID = 278, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_93 });
            context.KT_Answers.Add(new KT_Answer { ID = 279, AnswerNumber = "с", AnswerText = "я расстраиваюсь", KT_Question = q_93 });

            KT_Question q_94 = context.KT_Questions.FirstOrDefault(q => q.ID == 94);
            context.KT_Answers.Add(new KT_Answer { ID = 280, AnswerNumber = "а", AnswerText = "да", KT_Question = q_94 });
            context.KT_Answers.Add(new KT_Answer { ID = 281, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_94 });
            context.KT_Answers.Add(new KT_Answer { ID = 282, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_94 });

            KT_Question q_95 = context.KT_Questions.FirstOrDefault(q => q.ID == 95);
            context.KT_Answers.Add(new KT_Answer { ID = 283, AnswerNumber = "а", AnswerText = "с постоянным окладом", KT_Question = q_95 });
            context.KT_Answers.Add(new KT_Answer { ID = 284, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_95 });
            context.KT_Answers.Add(new KT_Answer { ID = 285, AnswerNumber = "с", AnswerText = "с большим окладом, который бы зависел от моей способности показать людям, чего я стою", KT_Question = q_95 });

            KT_Question q_96 = context.KT_Questions.FirstOrDefault(q => q.ID == 96);
            context.KT_Answers.Add(new KT_Answer { ID = 286, AnswerNumber = "а", AnswerText = "в общении с людьми", KT_Question = q_96 });
            context.KT_Answers.Add(new KT_Answer { ID = 287, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_96 });
            context.KT_Answers.Add(new KT_Answer { ID = 288, AnswerNumber = "с", AnswerText = "из литературы", KT_Question = q_96 });

            KT_Question q_97 = context.KT_Questions.FirstOrDefault(q => q.ID == 97);
            context.KT_Answers.Add(new KT_Answer { ID = 289, AnswerNumber = "а", AnswerText = "да", KT_Question = q_97 });
            context.KT_Answers.Add(new KT_Answer { ID = 290, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_97 });
            context.KT_Answers.Add(new KT_Answer { ID = 291, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_97 });

            KT_Question q_98 = context.KT_Questions.FirstOrDefault(q => q.ID == 98);
            context.KT_Answers.Add(new KT_Answer { ID = 292, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_98 });
            context.KT_Answers.Add(new KT_Answer { ID = 293, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_98 });
            context.KT_Answers.Add(new KT_Answer { ID = 294, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_98 });

            KT_Question q_99 = context.KT_Questions.FirstOrDefault(q => q.ID == 99);
            context.KT_Answers.Add(new KT_Answer { ID = 295, AnswerNumber = "а", AnswerText = "да", KT_Question = q_99 });
            context.KT_Answers.Add(new KT_Answer { ID = 296, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_99 });
            context.KT_Answers.Add(new KT_Answer { ID = 297, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_99 });

            KT_Question q_100 = context.KT_Questions.FirstOrDefault(q => q.ID == 100);
            context.KT_Answers.Add(new KT_Answer { ID = 298, AnswerNumber = "а", AnswerText = "да", KT_Question = q_100 });
            context.KT_Answers.Add(new KT_Answer { ID = 299, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_100 });
            context.KT_Answers.Add(new KT_Answer { ID = 300, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_100 });

            KT_Question q_101 = context.KT_Questions.FirstOrDefault(q => q.ID == 101);
            context.KT_Answers.Add(new KT_Answer { ID = 301, AnswerNumber = "а", AnswerText = "нужно разговаривать с людьми", KT_Question = q_101 });
            context.KT_Answers.Add(new KT_Answer { ID = 302, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_101 });
            context.KT_Answers.Add(new KT_Answer { ID = 303, AnswerNumber = "с", AnswerText = "нужно заниматься счетами и записями", KT_Question = q_101 });

            KT_Question q_102 = context.KT_Questions.FirstOrDefault(q => q.ID == 102);
            context.KT_Answers.Add(new KT_Answer { ID = 304, AnswerNumber = "а", AnswerText = "«тюрьма»", KT_Question = q_102 });
            context.KT_Answers.Add(new KT_Answer { ID = 305, AnswerNumber = "в", AnswerText = "«нарушение»", KT_Question = q_102 });
            context.KT_Answers.Add(new KT_Answer { ID = 306, AnswerNumber = "с", AnswerText = "«кража»", KT_Question = q_102 });

            KT_Question q_103 = context.KT_Questions.FirstOrDefault(q => q.ID == 103);
            context.KT_Answers.Add(new KT_Answer { ID = 307, AnswerNumber = "а", AnswerText = "«ПО»", KT_Question = q_103 });
            context.KT_Answers.Add(new KT_Answer { ID = 308, AnswerNumber = "в", AnswerText = "«ОП»", KT_Question = q_103 });
            context.KT_Answers.Add(new KT_Answer { ID = 309, AnswerNumber = "с", AnswerText = "«ТУ»", KT_Question = q_103 });

            KT_Question q_104 = context.KT_Questions.FirstOrDefault(q => q.ID == 104);
            context.KT_Answers.Add(new KT_Answer { ID = 310, AnswerNumber = "а", AnswerText = "молчу", KT_Question = q_104 });
            context.KT_Answers.Add(new KT_Answer { ID = 311, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_104 });
            context.KT_Answers.Add(new KT_Answer { ID = 312, AnswerNumber = "с", AnswerText = "высказываю свое презрение", KT_Question = q_104 });

            KT_Question q_105 = context.KT_Questions.FirstOrDefault(q => q.ID == 105);
            context.KT_Answers.Add(new KT_Answer { ID = 313, AnswerNumber = "а", AnswerText = "могу сосредоточиться на музыке, не отвлекаться", KT_Question = q_105 });
            context.KT_Answers.Add(new KT_Answer { ID = 314, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_105 });
            context.KT_Answers.Add(new KT_Answer { ID = 315, AnswerNumber = "с", AnswerText = "чувствую, что это портит мне удовольствие и раздражает", KT_Question = q_105 });

            KT_Question q_106 = context.KT_Questions.FirstOrDefault(q => q.ID == 106);
            context.KT_Answers.Add(new KT_Answer { ID = 316, AnswerNumber = "а", AnswerText = "вежливого и спокойного", KT_Question = q_106 });
            context.KT_Answers.Add(new KT_Answer { ID = 317, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_106 });
            context.KT_Answers.Add(new KT_Answer { ID = 318, AnswerNumber = "с", AnswerText = "энергичного", KT_Question = q_106 });

            KT_Question q_107 = context.KT_Questions.FirstOrDefault(q => q.ID == 107);
            context.KT_Answers.Add(new KT_Answer { ID = 319, AnswerNumber = "а", AnswerText = "да", KT_Question = q_107 });
            context.KT_Answers.Add(new KT_Answer { ID = 320, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_107 });
            context.KT_Answers.Add(new KT_Answer { ID = 321, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_107 });

            KT_Question q_108 = context.KT_Questions.FirstOrDefault(q => q.ID == 108);
            context.KT_Answers.Add(new KT_Answer { ID = 322, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_108 });
            context.KT_Answers.Add(new KT_Answer { ID = 323, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_108 });
            context.KT_Answers.Add(new KT_Answer { ID = 324, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_108 });

            KT_Question q_109 = context.KT_Questions.FirstOrDefault(q => q.ID == 109);
            context.KT_Answers.Add(new KT_Answer { ID = 325, AnswerNumber = "а", AnswerText = "стараюсь планировать заранее, прежде чем встретить трудность", KT_Question = q_109 });
            context.KT_Answers.Add(new KT_Answer { ID = 326, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_109 });
            context.KT_Answers.Add(new KT_Answer { ID = 327, AnswerNumber = "с", AnswerText = "считаю, что справлюсь с трудностями по мере того, как они возникнут", KT_Question = q_109 });

            KT_Question q_110 = context.KT_Questions.FirstOrDefault(q => q.ID == 110);
            context.KT_Answers.Add(new KT_Answer { ID = 328, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_110 });
            context.KT_Answers.Add(new KT_Answer { ID = 329, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_110 });
            context.KT_Answers.Add(new KT_Answer { ID = 330, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_110 });

            KT_Question q_111 = context.KT_Questions.FirstOrDefault(q => q.ID == 111);
            context.KT_Answers.Add(new KT_Answer { ID = 331, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_111 });
            context.KT_Answers.Add(new KT_Answer { ID = 332, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_111 });
            context.KT_Answers.Add(new KT_Answer { ID = 333, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_111 });

            KT_Question q_112 = context.KT_Questions.FirstOrDefault(q => q.ID == 112);
            context.KT_Answers.Add(new KT_Answer { ID = 334, AnswerNumber = "а", AnswerText = "консультантом, помогающим людям выбирать профессию", KT_Question = q_112 });
            context.KT_Answers.Add(new KT_Answer { ID = 335, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_112 });
            context.KT_Answers.Add(new KT_Answer { ID = 336, AnswerNumber = "с", AnswerText = "руководителем технического предприятия", KT_Question = q_112 });

            KT_Question q_113 = context.KT_Questions.FirstOrDefault(q => q.ID == 113);
            context.KT_Answers.Add(new KT_Answer { ID = 337, AnswerNumber = "а", AnswerText = "да", KT_Question = q_113 });
            context.KT_Answers.Add(new KT_Answer { ID = 338, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_113 });
            context.KT_Answers.Add(new KT_Answer { ID = 339, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_113 });

            KT_Question q_114 = context.KT_Questions.FirstOrDefault(q => q.ID == 114);
            context.KT_Answers.Add(new KT_Answer { ID = 340, AnswerNumber = "а", AnswerText = "да", KT_Question = q_114 });
            context.KT_Answers.Add(new KT_Answer { ID = 341, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_114 });
            context.KT_Answers.Add(new KT_Answer { ID = 342, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_114 });

            KT_Question q_115 = context.KT_Questions.FirstOrDefault(q => q.ID == 115);
            context.KT_Answers.Add(new KT_Answer { ID = 343, AnswerNumber = "а", AnswerText = "да", KT_Question = q_115 });
            context.KT_Answers.Add(new KT_Answer { ID = 344, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_115 });
            context.KT_Answers.Add(new KT_Answer { ID = 345, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_115 });

            KT_Question q_116 = context.KT_Questions.FirstOrDefault(q => q.ID == 116);
            context.KT_Answers.Add(new KT_Answer { ID = 346, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_116 });
            context.KT_Answers.Add(new KT_Answer { ID = 347, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_116 });
            context.KT_Answers.Add(new KT_Answer { ID = 348, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_116 });

            KT_Question q_117 = context.KT_Questions.FirstOrDefault(q => q.ID == 117);
            context.KT_Answers.Add(new KT_Answer { ID = 349, AnswerNumber = "а", AnswerText = "он – лжец", KT_Question = q_117 });
            context.KT_Answers.Add(new KT_Answer { ID = 350, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_117 });
            context.KT_Answers.Add(new KT_Answer { ID = 351, AnswerNumber = "с", AnswerText = "по-видимому, он плохо информирован", KT_Question = q_117 });

            KT_Question q_118 = context.KT_Questions.FirstOrDefault(q => q.ID == 118);
            context.KT_Answers.Add(new KT_Answer { ID = 352, AnswerNumber = "а", AnswerText = "часто", KT_Question = q_118 });
            context.KT_Answers.Add(new KT_Answer { ID = 353, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_118 });
            context.KT_Answers.Add(new KT_Answer { ID = 354, AnswerNumber = "с", AnswerText = "никогда", KT_Question = q_118 });

            KT_Question q_119 = context.KT_Questions.FirstOrDefault(q => q.ID == 119);
            context.KT_Answers.Add(new KT_Answer { ID = 355, AnswerNumber = "а", AnswerText = "да", KT_Question = q_119 });
            context.KT_Answers.Add(new KT_Answer { ID = 356, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_119 });
            context.KT_Answers.Add(new KT_Answer { ID = 357, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_119 });

            KT_Question q_120 = context.KT_Questions.FirstOrDefault(q => q.ID == 120);
            context.KT_Answers.Add(new KT_Answer { ID = 358, AnswerNumber = "а", AnswerText = "да", KT_Question = q_120 });
            context.KT_Answers.Add(new KT_Answer { ID = 359, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_120 });
            context.KT_Answers.Add(new KT_Answer { ID = 360, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_120 });

            KT_Question q_121 = context.KT_Questions.FirstOrDefault(q => q.ID == 121);
            context.KT_Answers.Add(new KT_Answer { ID = 361, AnswerNumber = "а", AnswerText = "очень", KT_Question = q_121 });
            context.KT_Answers.Add(new KT_Answer { ID = 362, AnswerNumber = "в", AnswerText = "немного", KT_Question = q_121 });
            context.KT_Answers.Add(new KT_Answer { ID = 363, AnswerNumber = "с", AnswerText = "совсем не беспокоит", KT_Question = q_121 });

            KT_Question q_122 = context.KT_Questions.FirstOrDefault(q => q.ID == 122);
            context.KT_Answers.Add(new KT_Answer { ID = 364, AnswerNumber = "а", AnswerText = "в составе коллектива", KT_Question = q_122 });
            context.KT_Answers.Add(new KT_Answer { ID = 365, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_122 });
            context.KT_Answers.Add(new KT_Answer { ID = 366, AnswerNumber = "с", AnswerText = "самостоятельно", KT_Question = q_122 });

            KT_Question q_123 = context.KT_Questions.FirstOrDefault(q => q.ID == 123);
            context.KT_Answers.Add(new KT_Answer { ID = 367, AnswerNumber = "а", AnswerText = "часто", KT_Question = q_123 });
            context.KT_Answers.Add(new KT_Answer { ID = 368, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_123 });
            context.KT_Answers.Add(new KT_Answer { ID = 369, AnswerNumber = "с", AnswerText = "никогда", KT_Question = q_123 });

            KT_Question q_124 = context.KT_Questions.FirstOrDefault(q => q.ID == 124);
            context.KT_Answers.Add(new KT_Answer { ID = 370, AnswerNumber = "а", AnswerText = "да", KT_Question = q_124 });
            context.KT_Answers.Add(new KT_Answer { ID = 371, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_124 });
            context.KT_Answers.Add(new KT_Answer { ID = 372, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_124 });

            KT_Question q_125 = context.KT_Questions.FirstOrDefault(q => q.ID == 125);
            context.KT_Answers.Add(new KT_Answer { ID = 373, AnswerNumber = "а", AnswerText = "да", KT_Question = q_125 });
            context.KT_Answers.Add(new KT_Answer { ID = 374, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_125 });
            context.KT_Answers.Add(new KT_Answer { ID = 375, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_125 });

            KT_Question q_126 = context.KT_Questions.FirstOrDefault(q => q.ID == 126);
            context.KT_Answers.Add(new KT_Answer { ID = 376, AnswerNumber = "а", AnswerText = "адвокатом", KT_Question = q_126 });
            context.KT_Answers.Add(new KT_Answer { ID = 377, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_126 });
            context.KT_Answers.Add(new KT_Answer { ID = 378, AnswerNumber = "с", AnswerText = "пилотом или капитаном судна", KT_Question = q_126 });

            KT_Question q_127 = context.KT_Questions.FirstOrDefault(q => q.ID == 127);
            context.KT_Answers.Add(new KT_Answer { ID = 379, AnswerNumber = "а", AnswerText = "«быстрое»", KT_Question = q_127 });
            context.KT_Answers.Add(new KT_Answer { ID = 380, AnswerNumber = "в", AnswerText = "«лучшее»", KT_Question = q_127 });
            context.KT_Answers.Add(new KT_Answer { ID = 381, AnswerNumber = "с", AnswerText = "«быстрейшее»", KT_Question = q_127 });

            KT_Question q_128 = context.KT_Questions.FirstOrDefault(q => q.ID == 128);
            context.KT_Answers.Add(new KT_Answer { ID = 382, AnswerNumber = "а", AnswerText = "ОРРР", KT_Question = q_128 });
            context.KT_Answers.Add(new KT_Answer { ID = 383, AnswerNumber = "в", AnswerText = "ООРР", KT_Question = q_128 });
            context.KT_Answers.Add(new KT_Answer { ID = 384, AnswerNumber = "с", AnswerText = "РООО", KT_Question = q_128 });

            KT_Question q_129 = context.KT_Questions.FirstOrDefault(q => q.ID == 129);
            context.KT_Answers.Add(new KT_Answer { ID = 385, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_129 });
            context.KT_Answers.Add(new KT_Answer { ID = 386, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_129 });
            context.KT_Answers.Add(new KT_Answer { ID = 387, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_129 });

            KT_Question q_130 = context.KT_Questions.FirstOrDefault(q => q.ID == 130);
            context.KT_Answers.Add(new KT_Answer { ID = 388, AnswerNumber = "а", AnswerText = "да", KT_Question = q_130 });
            context.KT_Answers.Add(new KT_Answer { ID = 389, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_130 });
            context.KT_Answers.Add(new KT_Answer { ID = 390, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_130 });

            KT_Question q_131 = context.KT_Questions.FirstOrDefault(q => q.ID == 131);
            context.KT_Answers.Add(new KT_Answer { ID = 391, AnswerNumber = "а", AnswerText = "да", KT_Question = q_131 });
            context.KT_Answers.Add(new KT_Answer { ID = 392, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_131 });
            context.KT_Answers.Add(new KT_Answer { ID = 393, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_131 });

            KT_Question q_132 = context.KT_Questions.FirstOrDefault(q => q.ID == 132);
            context.KT_Answers.Add(new KT_Answer { ID = 394, AnswerNumber = "а", AnswerText = "да", KT_Question = q_132 });
            context.KT_Answers.Add(new KT_Answer { ID = 395, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_132 });
            context.KT_Answers.Add(new KT_Answer { ID = 396, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_132 });

            KT_Question q_133 = context.KT_Questions.FirstOrDefault(q => q.ID == 133);
            context.KT_Answers.Add(new KT_Answer { ID = 397, AnswerNumber = "а", AnswerText = "да", KT_Question = q_133 });
            context.KT_Answers.Add(new KT_Answer { ID = 398, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_133 });
            context.KT_Answers.Add(new KT_Answer { ID = 399, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_133 });

            KT_Question q_134 = context.KT_Questions.FirstOrDefault(q => q.ID == 134);
            context.KT_Answers.Add(new KT_Answer { ID = 400, AnswerNumber = "а", AnswerText = "да", KT_Question = q_134 });
            context.KT_Answers.Add(new KT_Answer { ID = 401, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_134 });
            context.KT_Answers.Add(new KT_Answer { ID = 402, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_134 });

            KT_Question q_135 = context.KT_Questions.FirstOrDefault(q => q.ID == 135);
            context.KT_Answers.Add(new KT_Answer { ID = 403, AnswerNumber = "а", AnswerText = "да", KT_Question = q_135 });
            context.KT_Answers.Add(new KT_Answer { ID = 404, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_135 });
            context.KT_Answers.Add(new KT_Answer { ID = 405, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_135 });

            KT_Question q_136 = context.KT_Questions.FirstOrDefault(q => q.ID == 136);
            context.KT_Answers.Add(new KT_Answer { ID = 406, AnswerNumber = "а", AnswerText = "свободно проявляю свои чувства", KT_Question = q_136 });
            context.KT_Answers.Add(new KT_Answer { ID = 407, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_136 });
            context.KT_Answers.Add(new KT_Answer { ID = 408, AnswerNumber = "с", AnswerText = "держу свои переживания «при себе»", KT_Question = q_136 });

            KT_Question q_137 = context.KT_Questions.FirstOrDefault(q => q.ID == 137);
            context.KT_Answers.Add(new KT_Answer { ID = 409, AnswerNumber = "а", AnswerText = "легкую, живую", KT_Question = q_137 });
            context.KT_Answers.Add(new KT_Answer { ID = 410, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_137 });
            context.KT_Answers.Add(new KT_Answer { ID = 411, AnswerNumber = "с", AnswerText = "чувствительную", KT_Question = q_137 });

            KT_Question q_138 = context.KT_Questions.FirstOrDefault(q => q.ID == 138);
            context.KT_Answers.Add(new KT_Answer { ID = 412, AnswerNumber = "а", AnswerText = "да", KT_Question = q_138 });
            context.KT_Answers.Add(new KT_Answer { ID = 413, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_138 });
            context.KT_Answers.Add(new KT_Answer { ID = 414, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_138 });

            KT_Question q_139 = context.KT_Questions.FirstOrDefault(q => q.ID == 139);
            context.KT_Answers.Add(new KT_Answer { ID = 415, AnswerNumber = "а", AnswerText = "смирюсь с этим", KT_Question = q_139 });
            context.KT_Answers.Add(new KT_Answer { ID = 416, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_139 });
            context.KT_Answers.Add(new KT_Answer { ID = 417, AnswerNumber = "с", AnswerText = "даю людям возможность услышать его еще раз", KT_Question = q_139 });

            KT_Question q_140 = context.KT_Questions.FirstOrDefault(q => q.ID == 140);
            context.KT_Answers.Add(new KT_Answer { ID = 418, AnswerNumber = "а", AnswerText = "да", KT_Question = q_140 });
            context.KT_Answers.Add(new KT_Answer { ID = 419, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_140 });
            context.KT_Answers.Add(new KT_Answer { ID = 420, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_140 });

            KT_Question q_141 = context.KT_Questions.FirstOrDefault(q => q.ID == 141);
            context.KT_Answers.Add(new KT_Answer { ID = 421, AnswerNumber = "а", AnswerText = "да", KT_Question = q_141 });
            context.KT_Answers.Add(new KT_Answer { ID = 422, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_141 });
            context.KT_Answers.Add(new KT_Answer { ID = 423, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_141 });

            KT_Question q_142 = context.KT_Questions.FirstOrDefault(q => q.ID == 142);
            context.KT_Answers.Add(new KT_Answer { ID = 424, AnswerNumber = "а", AnswerText = "да", KT_Question = q_142 });
            context.KT_Answers.Add(new KT_Answer { ID = 425, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_142 });
            context.KT_Answers.Add(new KT_Answer { ID = 426, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_142 });

            KT_Question q_143 = context.KT_Questions.FirstOrDefault(q => q.ID == 143);
            context.KT_Answers.Add(new KT_Answer { ID = 427, AnswerNumber = "а", AnswerText = "да", KT_Question = q_143 });
            context.KT_Answers.Add(new KT_Answer { ID = 428, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_143 });
            context.KT_Answers.Add(new KT_Answer { ID = 429, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_143 });

            KT_Question q_144 = context.KT_Questions.FirstOrDefault(q => q.ID == 144);
            context.KT_Answers.Add(new KT_Answer { ID = 430, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_144 });
            context.KT_Answers.Add(new KT_Answer { ID = 431, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_144 });
            context.KT_Answers.Add(new KT_Answer { ID = 432, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_144 });

            KT_Question q_145 = context.KT_Questions.FirstOrDefault(q => q.ID == 145);
            context.KT_Answers.Add(new KT_Answer { ID = 433, AnswerNumber = "а", AnswerText = "увидеть, кто же «победил»", KT_Question = q_145 });
            context.KT_Answers.Add(new KT_Answer { ID = 434, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_145 });
            context.KT_Answers.Add(new KT_Answer { ID = 435, AnswerNumber = "с", AnswerText = "чтобы спор разрешился мирно", KT_Question = q_145 });

            KT_Question q_146 = context.KT_Questions.FirstOrDefault(q => q.ID == 146);
            context.KT_Answers.Add(new KT_Answer { ID = 436, AnswerNumber = "а", AnswerText = "да", KT_Question = q_146 });
            context.KT_Answers.Add(new KT_Answer { ID = 437, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_146 });
            context.KT_Answers.Add(new KT_Answer { ID = 438, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_146 });

            KT_Question q_147 = context.KT_Questions.FirstOrDefault(q => q.ID == 147);
            context.KT_Answers.Add(new KT_Answer { ID = 439, AnswerNumber = "а", AnswerText = "да", KT_Question = q_147 });
            context.KT_Answers.Add(new KT_Answer { ID = 440, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_147 });
            context.KT_Answers.Add(new KT_Answer { ID = 441, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_147 });

            KT_Question q_148 = context.KT_Questions.FirstOrDefault(q => q.ID == 148);
            context.KT_Answers.Add(new KT_Answer { ID = 442, AnswerNumber = "а", AnswerText = "да", KT_Question = q_148 });
            context.KT_Answers.Add(new KT_Answer { ID = 443, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_148 });
            context.KT_Answers.Add(new KT_Answer { ID = 444, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_148 });

            KT_Question q_149 = context.KT_Questions.FirstOrDefault(q => q.ID == 149);
            context.KT_Answers.Add(new KT_Answer { ID = 445, AnswerNumber = "а", AnswerText = "да", KT_Question = q_149 });
            context.KT_Answers.Add(new KT_Answer { ID = 446, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_149 });
            context.KT_Answers.Add(new KT_Answer { ID = 447, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_149 });

            KT_Question q_150 = context.KT_Questions.FirstOrDefault(q => q.ID == 150);
            context.KT_Answers.Add(new KT_Answer { ID = 448, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_150 });
            context.KT_Answers.Add(new KT_Answer { ID = 449, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_150 });
            context.KT_Answers.Add(new KT_Answer { ID = 450, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_150 });

            KT_Question q_151 = context.KT_Questions.FirstOrDefault(q => q.ID == 151);
            context.KT_Answers.Add(new KT_Answer { ID = 451, AnswerNumber = "а", AnswerText = "художником", KT_Question = q_151 });
            context.KT_Answers.Add(new KT_Answer { ID = 452, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_151 });
            context.KT_Answers.Add(new KT_Answer { ID = 453, AnswerNumber = "с", AnswerText = "организатором культурных развлечений", KT_Question = q_151 });

            KT_Question q_152 = context.KT_Questions.FirstOrDefault(q => q.ID == 152);
            context.KT_Answers.Add(new KT_Answer { ID = 454, AnswerNumber = "а", AnswerText = "любые", KT_Question = q_152 });
            context.KT_Answers.Add(new KT_Answer { ID = 455, AnswerNumber = "в", AnswerText = "некоторые", KT_Question = q_152 });
            context.KT_Answers.Add(new KT_Answer { ID = 456, AnswerNumber = "с", AnswerText = "большинство", KT_Question = q_152 });

            KT_Question q_153 = context.KT_Questions.FirstOrDefault(q => q.ID == 153);
            context.KT_Answers.Add(new KT_Answer { ID = 457, AnswerNumber = "а", AnswerText = "«шип»", KT_Question = q_153 });
            context.KT_Answers.Add(new KT_Answer { ID = 458, AnswerNumber = "в", AnswerText = "«красивые лепестки»", KT_Question = q_153 });
            context.KT_Answers.Add(new KT_Answer { ID = 459, AnswerNumber = "с", AnswerText = "«аромат»", KT_Question = q_153 });

            KT_Question q_154 = context.KT_Questions.FirstOrDefault(q => q.ID == 154);
            context.KT_Answers.Add(new KT_Answer { ID = 460, AnswerNumber = "а", AnswerText = "часто", KT_Question = q_154 });
            context.KT_Answers.Add(new KT_Answer { ID = 461, AnswerNumber = "в", AnswerText = "иногда", KT_Question = q_154 });
            context.KT_Answers.Add(new KT_Answer { ID = 462, AnswerNumber = "с", AnswerText = "практически никогда", KT_Question = q_154 });

            KT_Question q_155 = context.KT_Questions.FirstOrDefault(q => q.ID == 155);
            context.KT_Answers.Add(new KT_Answer { ID = 463, AnswerNumber = "а", AnswerText = "да", KT_Question = q_155 });
            context.KT_Answers.Add(new KT_Answer { ID = 464, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_155 });
            context.KT_Answers.Add(new KT_Answer { ID = 465, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_155 });

            KT_Question q_156 = context.KT_Questions.FirstOrDefault(q => q.ID == 156);
            context.KT_Answers.Add(new KT_Answer { ID = 466, AnswerNumber = "а", AnswerText = "да", KT_Question = q_156 });
            context.KT_Answers.Add(new KT_Answer { ID = 467, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_156 });
            context.KT_Answers.Add(new KT_Answer { ID = 468, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_156 });

            KT_Question q_157 = context.KT_Questions.FirstOrDefault(q => q.ID == 157);
            context.KT_Answers.Add(new KT_Answer { ID = 469, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_157 });
            context.KT_Answers.Add(new KT_Answer { ID = 470, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_157 });
            context.KT_Answers.Add(new KT_Answer { ID = 471, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_157 });

            KT_Question q_158 = context.KT_Questions.FirstOrDefault(q => q.ID == 158);
            context.KT_Answers.Add(new KT_Answer { ID = 472, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_158 });
            context.KT_Answers.Add(new KT_Answer { ID = 473, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_158 });
            context.KT_Answers.Add(new KT_Answer { ID = 474, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_158 });

            KT_Question q_159 = context.KT_Questions.FirstOrDefault(q => q.ID == 159);
            context.KT_Answers.Add(new KT_Answer { ID = 475, AnswerNumber = "а", AnswerText = "иногда", KT_Question = q_159 });
            context.KT_Answers.Add(new KT_Answer { ID = 476, AnswerNumber = "в", AnswerText = "почти никогда", KT_Question = q_159 });
            context.KT_Answers.Add(new KT_Answer { ID = 477, AnswerNumber = "с", AnswerText = "никогда", KT_Question = q_159 });

            KT_Question q_160 = context.KT_Questions.FirstOrDefault(q => q.ID == 160);
            context.KT_Answers.Add(new KT_Answer { ID = 478, AnswerNumber = "а", AnswerText = "да", KT_Question = q_160 });
            context.KT_Answers.Add(new KT_Answer { ID = 479, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_160 });
            context.KT_Answers.Add(new KT_Answer { ID = 480, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_160 });

            KT_Question q_161 = context.KT_Questions.FirstOrDefault(q => q.ID == 161);
            context.KT_Answers.Add(new KT_Answer { ID = 481, AnswerNumber = "а", AnswerText = "да", KT_Question = q_161 });
            context.KT_Answers.Add(new KT_Answer { ID = 482, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_161 });
            context.KT_Answers.Add(new KT_Answer { ID = 483, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_161 });

            KT_Question q_162 = context.KT_Questions.FirstOrDefault(q => q.ID == 162);
            context.KT_Answers.Add(new KT_Answer { ID = 484, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_162 });
            context.KT_Answers.Add(new KT_Answer { ID = 485, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_162 });
            context.KT_Answers.Add(new KT_Answer { ID = 486, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_162 });

            KT_Question q_163 = context.KT_Questions.FirstOrDefault(q => q.ID == 163);
            context.KT_Answers.Add(new KT_Answer { ID = 487, AnswerNumber = "а", AnswerText = "русский язык и литературу", KT_Question = q_163 });
            context.KT_Answers.Add(new KT_Answer { ID = 488, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_163 });
            context.KT_Answers.Add(new KT_Answer { ID = 489, AnswerNumber = "с", AnswerText = "математику или арифметику", KT_Question = q_163 });

            KT_Question q_164 = context.KT_Questions.FirstOrDefault(q => q.ID == 164);
            context.KT_Answers.Add(new KT_Answer { ID = 490, AnswerNumber = "а", AnswerText = "да", KT_Question = q_164 });
            context.KT_Answers.Add(new KT_Answer { ID = 491, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_164 });
            context.KT_Answers.Add(new KT_Answer { ID = 492, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_164 });

            KT_Question q_165 = context.KT_Questions.FirstOrDefault(q => q.ID == 165);
            context.KT_Answers.Add(new KT_Answer { ID = 493, AnswerNumber = "а", AnswerText = "часто вполне интересен и содержателен", KT_Question = q_165 });
            context.KT_Answers.Add(new KT_Answer { ID = 494, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_165 });
            context.KT_Answers.Add(new KT_Answer { ID = 495, AnswerNumber = "с", AnswerText = "раздражает меня, потому что ограничивается мелочами", KT_Question = q_165 });

            KT_Question q_166 = context.KT_Questions.FirstOrDefault(q => q.ID == 166);
            context.KT_Answers.Add(new KT_Answer { ID = 496, AnswerNumber = "а", AnswerText = "да", KT_Question = q_166 });
            context.KT_Answers.Add(new KT_Answer { ID = 497, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_166 });
            context.KT_Answers.Add(new KT_Answer { ID = 498, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_166 });

            KT_Question q_167 = context.KT_Questions.FirstOrDefault(q => q.ID == 167);
            context.KT_Answers.Add(new KT_Answer { ID = 499, AnswerNumber = "а", AnswerText = "относиться к ребенку с достаточной любовью", KT_Question = q_167 });
            context.KT_Answers.Add(new KT_Answer { ID = 500, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_167 });
            context.KT_Answers.Add(new KT_Answer { ID = 501, AnswerNumber = "с", AnswerText = "выработать нужные привычки и отношение к жизни", KT_Question = q_167 });

            KT_Question q_168 = context.KT_Questions.FirstOrDefault(q => q.ID == 168);
            context.KT_Answers.Add(new KT_Answer { ID = 502, AnswerNumber = "а", AnswerText = "да", KT_Question = q_168 });
            context.KT_Answers.Add(new KT_Answer { ID = 503, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_168 });
            context.KT_Answers.Add(new KT_Answer { ID = 504, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_168 });

            KT_Question q_169 = context.KT_Questions.FirstOrDefault(q => q.ID == 169);
            context.KT_Answers.Add(new KT_Answer { ID = 505, AnswerNumber = "а", AnswerText = "да", KT_Question = q_169 });
            context.KT_Answers.Add(new KT_Answer { ID = 506, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_169 });
            context.KT_Answers.Add(new KT_Answer { ID = 507, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_169 });

            KT_Question q_170 = context.KT_Questions.FirstOrDefault(q => q.ID == 170);
            context.KT_Answers.Add(new KT_Answer { ID = 508, AnswerNumber = "а", AnswerText = "вопросы нравственности", KT_Question = q_170 });
            context.KT_Answers.Add(new KT_Answer { ID = 509, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_170 });
            context.KT_Answers.Add(new KT_Answer { ID = 510, AnswerNumber = "с", AnswerText = "разногласия между странами мира", KT_Question = q_170 });

            KT_Question q_171 = context.KT_Questions.FirstOrDefault(q => q.ID == 171);
            context.KT_Answers.Add(new KT_Answer { ID = 511, AnswerNumber = "а", AnswerText = "читая хорошо написанную книгу", KT_Question = q_171 });
            context.KT_Answers.Add(new KT_Answer { ID = 512, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_171 });
            context.KT_Answers.Add(new KT_Answer { ID = 513, AnswerNumber = "с", AnswerText = "участвуя в обсуждении вопроса", KT_Question = q_171 });

            KT_Question q_172 = context.KT_Questions.FirstOrDefault(q => q.ID == 172);
            context.KT_Answers.Add(new KT_Answer { ID = 514, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_172 });
            context.KT_Answers.Add(new KT_Answer { ID = 515, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_172 });
            context.KT_Answers.Add(new KT_Answer { ID = 516, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_172 });

            KT_Question q_173 = context.KT_Questions.FirstOrDefault(q => q.ID == 173);
            context.KT_Answers.Add(new KT_Answer { ID = 517, AnswerNumber = "а", AnswerText = "всегда", KT_Question = q_173 });
            context.KT_Answers.Add(new KT_Answer { ID = 518, AnswerNumber = "в", AnswerText = "обычно", KT_Question = q_173 });
            context.KT_Answers.Add(new KT_Answer { ID = 519, AnswerNumber = "с", AnswerText = "только если это целесообразно", KT_Question = q_173 });

            KT_Question q_174 = context.KT_Questions.FirstOrDefault(q => q.ID == 174);
            context.KT_Answers.Add(new KT_Answer { ID = 520, AnswerNumber = "а", AnswerText = "да", KT_Question = q_174 });
            context.KT_Answers.Add(new KT_Answer { ID = 521, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_174 });
            context.KT_Answers.Add(new KT_Answer { ID = 522, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_174 });

            KT_Question q_175 = context.KT_Questions.FirstOrDefault(q => q.ID == 175);
            context.KT_Answers.Add(new KT_Answer { ID = 523, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_175 });
            context.KT_Answers.Add(new KT_Answer { ID = 524, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_175 });
            context.KT_Answers.Add(new KT_Answer { ID = 525, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_175 });

            KT_Question q_176 = context.KT_Questions.FirstOrDefault(q => q.ID == 176);
            context.KT_Answers.Add(new KT_Answer { ID = 526, AnswerNumber = "а", AnswerText = "согласился", KT_Question = q_176 });
            context.KT_Answers.Add(new KT_Answer { ID = 527, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_176 });
            context.KT_Answers.Add(new KT_Answer { ID = 528, AnswerNumber = "с", AnswerText = "вежливо сказал, что занят", KT_Question = q_176 });

            KT_Question q_177 = context.KT_Questions.FirstOrDefault(q => q.ID == 177);
            context.KT_Answers.Add(new KT_Answer { ID = 529, AnswerNumber = "а", AnswerText = "широкий", KT_Question = q_177 });
            context.KT_Answers.Add(new KT_Answer { ID = 530, AnswerNumber = "в", AnswerText = "зигзагообразный", KT_Question = q_177 });
            context.KT_Answers.Add(new KT_Answer { ID = 531, AnswerNumber = "с", AnswerText = "прямой", KT_Question = q_177 });

            KT_Question q_178 = context.KT_Questions.FirstOrDefault(q => q.ID == 178);
            context.KT_Answers.Add(new KT_Answer { ID = 532, AnswerNumber = "а", AnswerText = "«нигде»", KT_Question = q_178 });
            context.KT_Answers.Add(new KT_Answer { ID = 533, AnswerNumber = "в", AnswerText = "«далеко»", KT_Question = q_178 });
            context.KT_Answers.Add(new KT_Answer { ID = 534, AnswerNumber = "с", AnswerText = "«где-то»", KT_Question = q_178 });

            KT_Question q_179 = context.KT_Questions.FirstOrDefault(q => q.ID == 179);
            context.KT_Answers.Add(new KT_Answer { ID = 535, AnswerNumber = "а", AnswerText = "да", KT_Question = q_179 });
            context.KT_Answers.Add(new KT_Answer { ID = 536, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_179 });
            context.KT_Answers.Add(new KT_Answer { ID = 537, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_179 });

            KT_Question q_180 = context.KT_Questions.FirstOrDefault(q => q.ID == 180);
            context.KT_Answers.Add(new KT_Answer { ID = 538, AnswerNumber = "а", AnswerText = "да", KT_Question = q_180 });
            context.KT_Answers.Add(new KT_Answer { ID = 539, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_180 });
            context.KT_Answers.Add(new KT_Answer { ID = 540, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_180 });

            KT_Question q_181 = context.KT_Questions.FirstOrDefault(q => q.ID == 181);
            context.KT_Answers.Add(new KT_Answer { ID = 541, AnswerNumber = "а", AnswerText = "в трудных ситуациях, когда нужно сохранить самообладание", KT_Question = q_181 });
            context.KT_Answers.Add(new KT_Answer { ID = 542, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_181 });
            context.KT_Answers.Add(new KT_Answer { ID = 543, AnswerNumber = "с", AnswerText = "когда требуется умение ладить с людьми", KT_Question = q_181 });

            KT_Question q_182 = context.KT_Questions.FirstOrDefault(q => q.ID == 182);
            context.KT_Answers.Add(new KT_Answer { ID = 544, AnswerNumber = "а", AnswerText = "да", KT_Question = q_182 });
            context.KT_Answers.Add(new KT_Answer { ID = 545, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_182 });
            context.KT_Answers.Add(new KT_Answer { ID = 546, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_182 });

            KT_Question q_183 = context.KT_Questions.FirstOrDefault(q => q.ID == 183);
            context.KT_Answers.Add(new KT_Answer { ID = 547, AnswerNumber = "а", AnswerText = "да", KT_Question = q_183 });
            context.KT_Answers.Add(new KT_Answer { ID = 548, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_183 });
            context.KT_Answers.Add(new KT_Answer { ID = 549, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_183 });

            KT_Question q_184 = context.KT_Questions.FirstOrDefault(q => q.ID == 184);
            context.KT_Answers.Add(new KT_Answer { ID = 550, AnswerNumber = "а", AnswerText = "верно", KT_Question = q_184 });
            context.KT_Answers.Add(new KT_Answer { ID = 551, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_184 });
            context.KT_Answers.Add(new KT_Answer { ID = 552, AnswerNumber = "с", AnswerText = "неверно", KT_Question = q_184 });

            KT_Question q_185 = context.KT_Questions.FirstOrDefault(q => q.ID == 185);
            context.KT_Answers.Add(new KT_Answer { ID = 553, AnswerNumber = "а", AnswerText = "да", KT_Question = q_185 });
            context.KT_Answers.Add(new KT_Answer { ID = 554, AnswerNumber = "в", AnswerText = "нечто среднее", KT_Question = q_185 });
            context.KT_Answers.Add(new KT_Answer { ID = 555, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_185 });

            KT_Question q_186 = context.KT_Questions.FirstOrDefault(q => q.ID == 186);
            context.KT_Answers.Add(new KT_Answer { ID = 556, AnswerNumber = "а", AnswerText = "да", KT_Question = q_186 });
            context.KT_Answers.Add(new KT_Answer { ID = 557, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_186 });
            context.KT_Answers.Add(new KT_Answer { ID = 558, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_186 });

            KT_Question q_187 = context.KT_Questions.FirstOrDefault(q => q.ID == 187);
            context.KT_Answers.Add(new KT_Answer { ID = 559, AnswerNumber = "а", AnswerText = "да", KT_Question = q_187 });
            context.KT_Answers.Add(new KT_Answer { ID = 560, AnswerNumber = "в", AnswerText = "не уверен", KT_Question = q_187 });
            context.KT_Answers.Add(new KT_Answer { ID = 561, AnswerNumber = "с", AnswerText = "нет", KT_Question = q_187 });

            context.KT_Categories.Add(new KT_Category { ID = 1, CategoryName = "A" });
            context.KT_Categories.Add(new KT_Category { ID = 2, CategoryName = "B" });
            context.KT_Categories.Add(new KT_Category { ID = 3, CategoryName = "C" });
            context.KT_Categories.Add(new KT_Category { ID = 4, CategoryName = "E" });
            context.KT_Categories.Add(new KT_Category { ID = 5, CategoryName = "F" });
            context.KT_Categories.Add(new KT_Category { ID = 6, CategoryName = "G" });
            context.KT_Categories.Add(new KT_Category { ID = 7, CategoryName = "H" });
            context.KT_Categories.Add(new KT_Category { ID = 8, CategoryName = "I" });
            context.KT_Categories.Add(new KT_Category { ID = 9, CategoryName = "L" });
            context.KT_Categories.Add(new KT_Category { ID = 10, CategoryName = "M" });
            context.KT_Categories.Add(new KT_Category { ID = 11, CategoryName = "N" });
            context.KT_Categories.Add(new KT_Category { ID = 12, CategoryName = "O" });
            context.KT_Categories.Add(new KT_Category { ID = 13, CategoryName = "Q1" });
            context.KT_Categories.Add(new KT_Category { ID = 14, CategoryName = "Q2" });
            context.KT_Categories.Add(new KT_Category { ID = 15, CategoryName = "Q3" });
            context.KT_Categories.Add(new KT_Category { ID = 16, CategoryName = "Q4" });


            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 3, Score = 2, AnswerNumber = "а", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 3, Score = 1, AnswerNumber = "в", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 4, Score = 2, AnswerNumber = "а", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 4, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 5, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 5, Score = 2, AnswerNumber = "с", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 6, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 6, Score = 2, AnswerNumber = "с", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 7, Score = 2, AnswerNumber = "а", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 7, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 8, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 8, Score = 2, AnswerNumber = "с", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 9, Score = 1, AnswerNumber = "в", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 9, Score = 2, AnswerNumber = "с", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 10, Score = 2, AnswerNumber = "а", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 10, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 11, Score = 1, AnswerNumber = "в", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 11, Score = 2, AnswerNumber = "с", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 12, Score = 2, AnswerNumber = "а", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 12, Score = 1, AnswerNumber = "в", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 13, Score = 1, AnswerNumber = "в", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 13, Score = 2, AnswerNumber = "с", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 14, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 14, Score = 2, AnswerNumber = "с", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 15, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 15, Score = 2, AnswerNumber = "с", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 16, Score = 1, AnswerNumber = "в", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 16, Score = 2, AnswerNumber = "с", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 17, Score = 2, AnswerNumber = "а", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 17, Score = 1, AnswerNumber = "в", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 18, Score = 2, AnswerNumber = "а", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 18, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 19, Score = 2, AnswerNumber = "с", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 19, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 20, Score = 2, AnswerNumber = "а", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 20, Score = 1, AnswerNumber = "в", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 21, Score = 1, AnswerNumber = "в", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 21, Score = 2, AnswerNumber = "с", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 22, Score = 1, AnswerNumber = "в", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 22, Score = 2, AnswerNumber = "с", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 23, Score = 1, AnswerNumber = "в", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 23, Score = 2, AnswerNumber = "с", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 24, Score = 1, AnswerNumber = "в", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 24, Score = 2, AnswerNumber = "с", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 25, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 25, Score = 2, AnswerNumber = "с", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 26, Score = 1, AnswerNumber = "в", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 26, Score = 2, AnswerNumber = "с", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 27, Score = 1, AnswerNumber = "в", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 27, Score = 2, AnswerNumber = "с", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 28, Score = 1, AnswerNumber = "в", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 29, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 29, Score = 2, AnswerNumber = "с", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 30, Score = 2, AnswerNumber = "а", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 30, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 31, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 31, Score = 2, AnswerNumber = "с", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 32, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 32, Score = 2, AnswerNumber = "с", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 33, Score = 2, AnswerNumber = "а", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 33, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 34, Score = 1, AnswerNumber = "в", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 34, Score = 2, AnswerNumber = "с", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 35, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 35, Score = 2, AnswerNumber = "с", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 36, Score = 2, AnswerNumber = "а", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 36, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 37, Score = 2, AnswerNumber = "а", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 37, Score = 1, AnswerNumber = "в", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 38, Score = 2, AnswerNumber = "а", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 38, Score = 1, AnswerNumber = "в", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 39, Score = 2, AnswerNumber = "а", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 39, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 40, Score = 2, AnswerNumber = "а", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 40, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 41, Score = 1, AnswerNumber = "в", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 41, Score = 2, AnswerNumber = "с", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 42, Score = 2, AnswerNumber = "а", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 42, Score = 1, AnswerNumber = "в", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 43, Score = 2, AnswerNumber = "а", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 43, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 44, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 44, Score = 2, AnswerNumber = "с", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 45, Score = 1, AnswerNumber = "в", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 45, Score = 2, AnswerNumber = "с", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 46, Score = 2, AnswerNumber = "а", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 46, Score = 1, AnswerNumber = "в", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 47, Score = 2, AnswerNumber = "а", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 47, Score = 1, AnswerNumber = "в", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 48, Score = 2, AnswerNumber = "а", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 48, Score = 1, AnswerNumber = "в", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 49, Score = 2, AnswerNumber = "а", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 49, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 50, Score = 2, AnswerNumber = "а", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 50, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 51, Score = 1, AnswerNumber = "в", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 51, Score = 2, AnswerNumber = "с", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 52, Score = 1, AnswerNumber = "в", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 52, Score = 2, AnswerNumber = "с", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 53, Score = 1, AnswerNumber = "в", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 54, Score = 1, AnswerNumber = "в", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 55, Score = 2, AnswerNumber = "а", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 55, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 56, Score = 2, AnswerNumber = "а", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 56, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 57, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 57, Score = 2, AnswerNumber = "с", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 58, Score = 2, AnswerNumber = "а", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 58, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 59, Score = 1, AnswerNumber = "в", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 59, Score = 2, AnswerNumber = "с", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 60, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 60, Score = 2, AnswerNumber = "с", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 61, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 61, Score = 2, AnswerNumber = "с", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 62, Score = 1, AnswerNumber = "в", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 62, Score = 2, AnswerNumber = "с", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 63, Score = 1, AnswerNumber = "в", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 63, Score = 2, AnswerNumber = "с", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 64, Score = 1, AnswerNumber = "в", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 64, Score = 2, AnswerNumber = "с", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 65, Score = 2, AnswerNumber = "а", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 65, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 66, Score = 1, AnswerNumber = "в", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 66, Score = 2, AnswerNumber = "с", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 67, Score = 1, AnswerNumber = "в", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 67, Score = 2, AnswerNumber = "с", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 68, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 68, Score = 2, AnswerNumber = "с", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 69, Score = 2, AnswerNumber = "а", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 69, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 70, Score = 2, AnswerNumber = "а", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 70, Score = 1, AnswerNumber = "в", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 71, Score = 2, AnswerNumber = "а", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 71, Score = 1, AnswerNumber = "в", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 72, Score = 2, AnswerNumber = "а", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 72, Score = 1, AnswerNumber = "в", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 73, Score = 2, AnswerNumber = "а", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 73, Score = 1, AnswerNumber = "в", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 74, Score = 2, AnswerNumber = "а", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 74, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 75, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 75, Score = 2, AnswerNumber = "с", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 76, Score = 1, AnswerNumber = "в", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 76, Score = 2, AnswerNumber = "с", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 77, Score = 1, AnswerNumber = "с", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 78, Score = 1, AnswerNumber = "в", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 79, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 79, Score = 2, AnswerNumber = "с", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 80, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 80, Score = 2, AnswerNumber = "с", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 81, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 81, Score = 2, AnswerNumber = "с", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 82, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 82, Score = 2, AnswerNumber = "с", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 83, Score = 2, AnswerNumber = "а", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 83, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 84, Score = 1, AnswerNumber = "в", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 84, Score = 2, AnswerNumber = "с", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 85, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 85, Score = 2, AnswerNumber = "с", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 86, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 86, Score = 2, AnswerNumber = "с", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 87, Score = 1, AnswerNumber = "в", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 87, Score = 2, AnswerNumber = "с", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 88, Score = 2, AnswerNumber = "а", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 88, Score = 1, AnswerNumber = "в", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 89, Score = 1, AnswerNumber = "в", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 89, Score = 2, AnswerNumber = "с", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 90, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 90, Score = 2, AnswerNumber = "с", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 91, Score = 2, AnswerNumber = "а", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 91, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 92, Score = 1, AnswerNumber = "в", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 92, Score = 2, AnswerNumber = "с", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 93, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 93, Score = 2, AnswerNumber = "с", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 94, Score = 2, AnswerNumber = "а", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 94, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 95, Score = 1, AnswerNumber = "в", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 95, Score = 2, AnswerNumber = "с", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 96, Score = 1, AnswerNumber = "в", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 96, Score = 2, AnswerNumber = "с", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 97, Score = 1, AnswerNumber = "в", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 97, Score = 2, AnswerNumber = "с", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 98, Score = 2, AnswerNumber = "а", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 98, Score = 1, AnswerNumber = "в", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 99, Score = 2, AnswerNumber = "а", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 99, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 100, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 100, Score = 2, AnswerNumber = "с", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 101, Score = 2, AnswerNumber = "а", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 101, Score = 1, AnswerNumber = "в", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 102, Score = 1, AnswerNumber = "с", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 103, Score = 1, AnswerNumber = "в", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 104, Score = 2, AnswerNumber = "а", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 104, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 105, Score = 2, AnswerNumber = "а", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 105, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 106, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 106, Score = 2, AnswerNumber = "с", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 107, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 107, Score = 2, AnswerNumber = "с", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 108, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 108, Score = 2, AnswerNumber = "с", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 109, Score = 2, AnswerNumber = "а", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 109, Score = 1, AnswerNumber = "в", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 110, Score = 2, AnswerNumber = "а", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 110, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 111, Score = 2, AnswerNumber = "а", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 111, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 112, Score = 2, AnswerNumber = "а", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 112, Score = 1, AnswerNumber = "в", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 113, Score = 2, AnswerNumber = "а", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 113, Score = 1, AnswerNumber = "в", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 114, Score = 2, AnswerNumber = "а", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 114, Score = 1, AnswerNumber = "в", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 115, Score = 2, AnswerNumber = "а", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 115, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 116, Score = 2, AnswerNumber = "а", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 116, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 117, Score = 2, AnswerNumber = "а", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 117, Score = 1, AnswerNumber = "в", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 118, Score = 2, AnswerNumber = "а", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 118, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 119, Score = 2, AnswerNumber = "а", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 119, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 120, Score = 1, AnswerNumber = "в", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 120, Score = 2, AnswerNumber = "с", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 121, Score = 1, AnswerNumber = "в", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 121, Score = 2, AnswerNumber = "с", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 122, Score = 1, AnswerNumber = "в", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 122, Score = 2, AnswerNumber = "с", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 123, Score = 1, AnswerNumber = "в", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 123, Score = 2, AnswerNumber = "с", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 124, Score = 2, AnswerNumber = "а", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 124, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 125, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 125, Score = 2, AnswerNumber = "с", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 126, Score = 2, AnswerNumber = "а", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 126, Score = 1, AnswerNumber = "в", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 127, Score = 1, AnswerNumber = "с", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 128, Score = 1, AnswerNumber = "в", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 129, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 129, Score = 2, AnswerNumber = "с", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 130, Score = 2, AnswerNumber = "а", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 130, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 131, Score = 2, AnswerNumber = "а", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 131, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 132, Score = 2, AnswerNumber = "а", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 132, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 133, Score = 2, AnswerNumber = "а", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 133, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 134, Score = 2, AnswerNumber = "а", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 134, Score = 1, AnswerNumber = "в", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 135, Score = 2, AnswerNumber = "а", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 135, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 136, Score = 2, AnswerNumber = "а", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 136, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 137, Score = 1, AnswerNumber = "в", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 137, Score = 2, AnswerNumber = "с", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 138, Score = 2, AnswerNumber = "а", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 138, Score = 1, AnswerNumber = "в", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 139, Score = 1, AnswerNumber = "в", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 139, Score = 2, AnswerNumber = "с", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 140, Score = 2, AnswerNumber = "а", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 140, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 141, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 141, Score = 2, AnswerNumber = "с", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 142, Score = 2, AnswerNumber = "а", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 142, Score = 1, AnswerNumber = "в", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 143, Score = 2, AnswerNumber = "а", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 143, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 144, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 144, Score = 2, AnswerNumber = "с", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 145, Score = 2, AnswerNumber = "а", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 145, Score = 1, AnswerNumber = "в", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 146, Score = 2, AnswerNumber = "а", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 146, Score = 1, AnswerNumber = "в", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 147, Score = 1, AnswerNumber = "в", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 147, Score = 2, AnswerNumber = "с", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 148, Score = 2, AnswerNumber = "а", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 148, Score = 1, AnswerNumber = "в", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 149, Score = 2, AnswerNumber = "а", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 149, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 150, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 150, Score = 2, AnswerNumber = "с", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 151, Score = 1, AnswerNumber = "в", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 151, Score = 2, AnswerNumber = "с", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 152, Score = 1, AnswerNumber = "а", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 153, Score = 1, AnswerNumber = "с", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 154, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 154, Score = 2, AnswerNumber = "с", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 155, Score = 2, AnswerNumber = "а", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 155, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 156, Score = 2, AnswerNumber = "а", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 156, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 157, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 157, Score = 2, AnswerNumber = "с", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 158, Score = 1, AnswerNumber = "в", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 158, Score = 2, AnswerNumber = "с", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 159, Score = 1, AnswerNumber = "в", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 159, Score = 2, AnswerNumber = "с", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 160, Score = 2, AnswerNumber = "а", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 160, Score = 1, AnswerNumber = "в", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 161, Score = 1, AnswerNumber = "в", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 161, Score = 2, AnswerNumber = "с", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 162, Score = 1, AnswerNumber = "в", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 162, Score = 2, AnswerNumber = "с", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 163, Score = 2, AnswerNumber = "а", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 163, Score = 1, AnswerNumber = "в", CategoryName = "I" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 164, Score = 2, AnswerNumber = "а", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 164, Score = 1, AnswerNumber = "в", CategoryName = "L" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 165, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 165, Score = 2, AnswerNumber = "с", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 166, Score = 1, AnswerNumber = "в", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 166, Score = 2, AnswerNumber = "с", CategoryName = "M" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 167, Score = 2, AnswerNumber = "а", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 167, Score = 1, AnswerNumber = "в", CategoryName = "N" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 168, Score = 1, AnswerNumber = "в", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 168, Score = 2, AnswerNumber = "с", CategoryName = "O" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 169, Score = 2, AnswerNumber = "а", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 169, Score = 1, AnswerNumber = "в", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 170, Score = 1, AnswerNumber = "в", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 170, Score = 2, AnswerNumber = "с", CategoryName = "Q1" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 171, Score = 2, AnswerNumber = "а", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 171, Score = 1, AnswerNumber = "в", CategoryName = "Q2" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 172, Score = 1, AnswerNumber = "в", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 172, Score = 2, AnswerNumber = "с", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 173, Score = 2, AnswerNumber = "а", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 173, Score = 1, AnswerNumber = "в", CategoryName = "Q3" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 174, Score = 2, AnswerNumber = "а", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 174, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 175, Score = 1, AnswerNumber = "в", CategoryName = "Q4" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 175, Score = 2, AnswerNumber = "с", CategoryName = "Q4" });

            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 176, Score = 2, AnswerNumber = "а", CategoryName = "A" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 176, Score = 1, AnswerNumber = "в", CategoryName = "A" });

            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 177, Score = 1, AnswerNumber = "а", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 178, Score = 1, AnswerNumber = "а", CategoryName = "B" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 179, Score = 2, AnswerNumber = "а", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 179, Score = 1, AnswerNumber = "в", CategoryName = "C" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 180, Score = 2, AnswerNumber = "а", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 180, Score = 1, AnswerNumber = "в", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 181, Score = 2, AnswerNumber = "а", CategoryName = "E" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 181, Score = 1, AnswerNumber = "в", CategoryName = "E" });

            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 182, Score = 2, AnswerNumber = "а", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 182, Score = 1, AnswerNumber = "в", CategoryName = "F" });

            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 183, Score = 2, AnswerNumber = "а", CategoryName = "F" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 183, Score = 1, AnswerNumber = "в", CategoryName = "F" });

            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 184, Score = 2, AnswerNumber = "а", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 184, Score = 1, AnswerNumber = "в", CategoryName = "G" });

            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 185, Score = 2, AnswerNumber = "а", CategoryName = "G" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 185, Score = 1, AnswerNumber = "в", CategoryName = "G" });

            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 186, Score = 2, AnswerNumber = "а", CategoryName = "H" });
            context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber = 186, Score = 1, AnswerNumber = "в", CategoryName = "H" });

            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 0, ScoreFrom = 0, ScoreTo = 2 });
            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 1, ScoreFrom = 3, ScoreTo = 4 });
            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 2, ScoreFrom = 5, ScoreTo = 6 });
            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 3, ScoreFrom = 7, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 4, ScoreFrom = 8, ScoreTo = 8 });
            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 5, ScoreFrom = 9, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 6, ScoreFrom = 10, ScoreTo = 11 });
            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 7, ScoreFrom = 12, ScoreTo = 12 });
            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 8, ScoreFrom = 13, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 9, ScoreFrom = 14, ScoreTo = 15 });
            context.KT_Marks.Add(new KT_Mark { Category = "A", Mark = 10, ScoreFrom = 16, ScoreTo = 19 });
            context.KT_Marks.Add(new KT_Mark { Category = "B", Mark = 1, ScoreFrom = 0, ScoreTo = 1 });
            context.KT_Marks.Add(new KT_Mark { Category = "B", Mark = 2, ScoreFrom = 2, ScoreTo = 3 });
            context.KT_Marks.Add(new KT_Mark { Category = "B", Mark = 3, ScoreFrom = 4, ScoreTo = 4 });
            context.KT_Marks.Add(new KT_Mark { Category = "B", Mark = 4, ScoreFrom = 5, ScoreTo = 5 });
            context.KT_Marks.Add(new KT_Mark { Category = "B", Mark = 5, ScoreFrom = 6, ScoreTo = 6 });
            context.KT_Marks.Add(new KT_Mark { Category = "B", Mark = 6, ScoreFrom = 7, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "B", Mark = 7, ScoreFrom = 8, ScoreTo = 8 });
            context.KT_Marks.Add(new KT_Mark { Category = "B", Mark = 8, ScoreFrom = 9, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "B", Mark = 9, ScoreFrom = 10, ScoreTo = 10 });
            context.KT_Marks.Add(new KT_Mark { Category = "B", Mark = 10, ScoreFrom = 11, ScoreTo = 17 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 0, ScoreFrom = 0, ScoreTo = 0 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 1, ScoreFrom = 1, ScoreTo = 6 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 2, ScoreFrom = 7, ScoreTo = 8 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 3, ScoreFrom = 9, ScoreTo = 10 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 4, ScoreFrom = 11, ScoreTo = 12 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 5, ScoreFrom = 13, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 6, ScoreFrom = 14, ScoreTo = 15 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 7, ScoreFrom = 16, ScoreTo = 17 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 8, ScoreFrom = 18, ScoreTo = 20 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 9, ScoreFrom = 21, ScoreTo = 21 });
            context.KT_Marks.Add(new KT_Mark { Category = "C", Mark = 10, ScoreFrom = 22, ScoreTo = 26 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 0, ScoreFrom = 0, ScoreTo = 1 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 1, ScoreFrom = 2, ScoreTo = 4 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 2, ScoreFrom = 5, ScoreTo = 6 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 3, ScoreFrom = 7, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 4, ScoreFrom = 8, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 5, ScoreFrom = 10, ScoreTo = 10 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 6, ScoreFrom = 11, ScoreTo = 12 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 7, ScoreFrom = 13, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 8, ScoreFrom = 14, ScoreTo = 15 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 9, ScoreFrom = 16, ScoreTo = 17 });
            context.KT_Marks.Add(new KT_Mark { Category = "E", Mark = 10, ScoreFrom = 18, ScoreTo = 22 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 0, ScoreFrom = 0, ScoreTo = 3 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 1, ScoreFrom = 4, ScoreTo = 5 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 2, ScoreFrom = 6, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 3, ScoreFrom = 8, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 4, ScoreFrom = 10, ScoreTo = 10 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 5, ScoreFrom = 11, ScoreTo = 12 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 6, ScoreFrom = 13, ScoreTo = 14 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 7, ScoreFrom = 15, ScoreTo = 16 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 8, ScoreFrom = 17, ScoreTo = 18 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 9, ScoreFrom = 19, ScoreTo = 20 });
            context.KT_Marks.Add(new KT_Mark { Category = "F", Mark = 10, ScoreFrom = 21, ScoreTo = 26 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 0, ScoreFrom = 0, ScoreTo = 1 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 1, ScoreFrom = 2, ScoreTo = 4 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 2, ScoreFrom = 5, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 3, ScoreFrom = 8, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 4, ScoreFrom = 10, ScoreTo = 11 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 5, ScoreFrom = 12, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 6, ScoreFrom = 14, ScoreTo = 14 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 7, ScoreFrom = 15, ScoreTo = 16 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 8, ScoreFrom = 17, ScoreTo = 17 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 9, ScoreFrom = 18, ScoreTo = 18 });
            context.KT_Marks.Add(new KT_Mark { Category = "G", Mark = 10, ScoreFrom = 19, ScoreTo = 22 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 0, ScoreFrom = 0, ScoreTo = 0 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 1, ScoreFrom = 1, ScoreTo = 3 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 2, ScoreFrom = 4, ScoreTo = 5 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 3, ScoreFrom = 6, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 4, ScoreFrom = 8, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 5, ScoreFrom = 10, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 6, ScoreFrom = 14, ScoreTo = 14 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 7, ScoreFrom = 15, ScoreTo = 16 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 8, ScoreFrom = 17, ScoreTo = 18 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 9, ScoreFrom = 19, ScoreTo = 20 });
            context.KT_Marks.Add(new KT_Mark { Category = "H", Mark = 10, ScoreFrom = 21, ScoreTo = 25 });
            context.KT_Marks.Add(new KT_Mark { Category = "I", Mark = 1, ScoreFrom = 0, ScoreTo = 3 });
            context.KT_Marks.Add(new KT_Mark { Category = "I", Mark = 2, ScoreFrom = 4, ScoreTo = 4 });
            context.KT_Marks.Add(new KT_Mark { Category = "I", Mark = 3, ScoreFrom = 5, ScoreTo = 5 });
            context.KT_Marks.Add(new KT_Mark { Category = "I", Mark = 4, ScoreFrom = 6, ScoreTo = 6 });
            context.KT_Marks.Add(new KT_Mark { Category = "I", Mark = 5, ScoreFrom = 7, ScoreTo = 8 });
            context.KT_Marks.Add(new KT_Mark { Category = "I", Mark = 6, ScoreFrom = 9, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "I", Mark = 7, ScoreFrom = 10, ScoreTo = 11 });
            context.KT_Marks.Add(new KT_Mark { Category = "I", Mark = 8, ScoreFrom = 12, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "I", Mark = 9, ScoreFrom = 14, ScoreTo = 14 });
            context.KT_Marks.Add(new KT_Mark { Category = "I", Mark = 10, ScoreFrom = 15, ScoreTo = 18 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 0, ScoreFrom = 0, ScoreTo = 1 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 1, ScoreFrom = 2, ScoreTo = 3 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 2, ScoreFrom = 4, ScoreTo = 5 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 3, ScoreFrom = 6, ScoreTo = 6 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 4, ScoreFrom = 7, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 5, ScoreFrom = 8, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 6, ScoreFrom = 10, ScoreTo = 10 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 7, ScoreFrom = 11, ScoreTo = 11 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 8, ScoreFrom = 12, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 9, ScoreFrom = 14, ScoreTo = 15 });
            context.KT_Marks.Add(new KT_Mark { Category = "L", Mark = 10, ScoreFrom = 16, ScoreTo = 18 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 0, ScoreFrom = 0, ScoreTo = 1 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 1, ScoreFrom = 2, ScoreTo = 3 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 2, ScoreFrom = 4, ScoreTo = 5 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 3, ScoreFrom = 6, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 4, ScoreFrom = 8, ScoreTo = 8 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 5, ScoreFrom = 9, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 6, ScoreFrom = 10, ScoreTo = 11 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 7, ScoreFrom = 12, ScoreTo = 12 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 8, ScoreFrom = 13, ScoreTo = 14 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 9, ScoreFrom = 15, ScoreTo = 16 });
            context.KT_Marks.Add(new KT_Mark { Category = "M", Mark = 10, ScoreFrom = 17, ScoreTo = 20 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 0, ScoreFrom = 0, ScoreTo = 1 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 1, ScoreFrom = 2, ScoreTo = 4 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 2, ScoreFrom = 5, ScoreTo = 5 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 3, ScoreFrom = 6, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 4, ScoreFrom = 8, ScoreTo = 8 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 5, ScoreFrom = 9, ScoreTo = 10 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 6, ScoreFrom = 11, ScoreTo = 11 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 7, ScoreFrom = 12, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 8, ScoreFrom = 14, ScoreTo = 15 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 9, ScoreFrom = 16, ScoreTo = 16 });
            context.KT_Marks.Add(new KT_Mark { Category = "N", Mark = 10, ScoreFrom = 17, ScoreTo = 20 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 0, ScoreFrom = 0, ScoreTo = 1 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 1, ScoreFrom = 2, ScoreTo = 4 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 2, ScoreFrom = 5, ScoreTo = 6 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 3, ScoreFrom = 7, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 4, ScoreFrom = 8, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 5, ScoreFrom = 10, ScoreTo = 11 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 6, ScoreFrom = 12, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 7, ScoreFrom = 14, ScoreTo = 15 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 8, ScoreFrom = 16, ScoreTo = 16 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 9, ScoreFrom = 17, ScoreTo = 18 });
            context.KT_Marks.Add(new KT_Mark { Category = "O", Mark = 10, ScoreFrom = 19, ScoreTo = 22 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 0, ScoreFrom = 0, ScoreTo = 1 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 1, ScoreFrom = 2, ScoreTo = 3 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 2, ScoreFrom = 4, ScoreTo = 4 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 3, ScoreFrom = 5, ScoreTo = 6 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 4, ScoreFrom = 7, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 5, ScoreFrom = 8, ScoreTo = 8 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 6, ScoreFrom = 9, ScoreTo = 10 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 7, ScoreFrom = 11, ScoreTo = 11 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 8, ScoreFrom = 12, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 9, ScoreFrom = 14, ScoreTo = 14 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q1", Mark = 10, ScoreFrom = 15, ScoreTo = 18 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q2", Mark = 1, ScoreFrom = 0, ScoreTo = 2 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q2", Mark = 2, ScoreFrom = 3, ScoreTo = 3 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q2", Mark = 3, ScoreFrom = 4, ScoreTo = 5 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q2", Mark = 4, ScoreFrom = 6, ScoreTo = 6 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q2", Mark = 5, ScoreFrom = 7, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q2", Mark = 6, ScoreFrom = 8, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q2", Mark = 7, ScoreFrom = 10, ScoreTo = 11 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q2", Mark = 8, ScoreFrom = 12, ScoreTo = 12 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q2", Mark = 9, ScoreFrom = 13, ScoreTo = 14 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q2", Mark = 10, ScoreFrom = 15, ScoreTo = 17 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 0, ScoreFrom = 0, ScoreTo = 2 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 1, ScoreFrom = 3, ScoreTo = 5 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 2, ScoreFrom = 6, ScoreTo = 7 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 3, ScoreFrom = 8, ScoreTo = 9 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 4, ScoreFrom = 10, ScoreTo = 10 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 5, ScoreFrom = 11, ScoreTo = 12 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 6, ScoreFrom = 13, ScoreTo = 13 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 7, ScoreFrom = 14, ScoreTo = 15 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 8, ScoreFrom = 16, ScoreTo = 16 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 9, ScoreFrom = 17, ScoreTo = 17 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q3", Mark = 10, ScoreFrom = 18, ScoreTo = 20 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q4", Mark = 1, ScoreFrom = 0, ScoreTo = 1 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q4", Mark = 2, ScoreFrom = 2, ScoreTo = 3 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q4", Mark = 3, ScoreFrom = 4, ScoreTo = 5 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q4", Mark = 4, ScoreFrom = 6, ScoreTo = 8 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q4", Mark = 5, ScoreFrom = 9, ScoreTo = 10 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q4", Mark = 6, ScoreFrom = 11, ScoreTo = 12 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q4", Mark = 7, ScoreFrom = 13, ScoreTo = 15 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q4", Mark = 8, ScoreFrom = 16, ScoreTo = 17 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q4", Mark = 9, ScoreFrom = 18, ScoreTo = 19 });
            context.KT_Marks.Add(new KT_Mark { Category = "Q4", Mark = 10, ScoreFrom = 20, ScoreTo = 22 });

            //context.KT_KeysForCategories.Add(new KT_KeysForCategory { QuestionNumber=3, Score=2, AnswerNumber="", CategoryName="" });
            context.SaveChanges();

        }
    }
}