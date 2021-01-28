using System;

namespace Book_26._01._2021
{
    class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();
        public Book(string title, string author, string content)
        {
            this.title.title = title;
            this.author.author = author;
            this.content.content = content;
        }
        public void showTitle()
        {
            title.Show();
        }
        public void showAuthor()
        {
            author.Show();
        }
        public void showContent()
        {
            content.Show();
        }
    }
    class Title
    {
        public string title { 
            get; set; 
        }
        public void Show()
        {
            Console.WriteLine($"Title: {title}");
        }
    }
    class Author
    {
        public string author { 
            get; set; 
        }
        public void Show()
        {
            Console.WriteLine($"Author: {author}");
        }
    }
    class Content
    {
        public string content { 
            get; set; 
        }
        public void Show()
        {
            Console.WriteLine($"Content: {content}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] author = { "Дмитрий Глуховский", "Стивен Кинг", "Андрей Левицкий, Дмитрий Янковский, Александр Зорич и т.д" };
            string[] title = { "Метро 2033", "Кладбище домашних животных", "S.T.A.L.K.E.R. " };
            string[] content = { "Двадцать лет спустя Третьей мировой войны последние выжившие люди прячутся на станциях и в туннелях московского метро, самого большого на Земле противоатомного бомбоубежища. Поверхность планеты заражена и непригодна для обитания, и станции метро становятся последним пристанищем для человека. Они превращаются в независимые города-государства, которые соперничают и воюют друг с другом. Они не готовы примириться даже перед лицом новой страшной опасности, которая угрожает всем людям окончательным истреблением. Артем, двадцатилетний парень со станции ВДНХ, должен пройти через все метро, чтобы спасти свой единственный дом – и все человечество. «Метро 2033» – культовый роман-антиутопия, один из главных российских бестселлеров нулевых. Переведен на 37 иностранных языков, заинтересовал Голливуд, превращен в атмосферные компьютерные блокбастеры, породил целую книжную вселенную и настоящую молодежную субкультуру во всем мире.", "Семья Луиса Крида переезжает в сельский дом, который, как выясняется, расположен по соседству с мрачным Кладбищем домашних животных. Именно здесь Луис хоронит кошку, любимицу семьи, погибшую под колесами грузовика. Эта смерть влечет за собой череду чудовищных событий, которые доказывают Кридам, что мертвые должны оставаться мертвыми…", "S.T.A.L.K.E.R. — книжная серия, продолжающая идею серии игр S.T.A.L.K.E.R. Действие большинства книг происходит в альтернативной реальности в Чернобыльской зоне отчуждения после вымышленной катастрофы 2006 года. Права на серию принадлежат украинской компании, разработчику серии игр, GSC Game World." };
            for (int i = 0; i < author.Length; i++)
            {
                Book book = new Book(title[i], author[i], content[i]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Книга №:{i + 1}:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                book.showTitle();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                book.showAuthor();
                Console.ForegroundColor = ConsoleColor.Blue;
                book.showContent();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
