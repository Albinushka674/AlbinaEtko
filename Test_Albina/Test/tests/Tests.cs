using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using Test.Visitors;

namespace Test
{
    [TestFixture]
    public class Tests
    {

        private const string BASE_URL = "http://silverscreen.by/";

        private BaseVisitor[] signInTestVisitors = { new SignInVisitor(), new IsSignedInVisitor(), new SignOutVisitor() };

        private BaseVisitor[] afishaGenreTestVisitors = { new ToNowInTheatersVisitor(), new DramaGenreVisitor() };

        private BaseVisitor[] alphabetAscendingTestVisitors = { new ToNowInTheatersVisitor(), new SetCinemaAlphabetOrder(), new SetCinemaOrderAscending() };

        private BaseVisitor[] alphabetDescendingTestVisitors = { new ToNowInTheatersVisitor(), new SetCinemaAlphabetOrder(), new SetCinemaOrderDescending() };

        private BaseVisitor[] dateAscendingTestVisitors = { new ToNowInTheatersVisitor(), new SetCinemaDateOrder(), new SetCinemaOrderAscending() };

        private BaseVisitor[] dateDescendingTestVisitors = { new ToNowInTheatersVisitor(), new SetCinemaDateOrder(), new SetCinemaOrderDescending() };

        private BaseVisitor[] test7Visitors = { new ToNowInTheatersVisitor(), new DramaGenreVisitor(), new SelectFirstCinema(), new SelectCinemaTodayDate(), new SelectFirstAvailableTime() };

        private BaseVisitor[] test8Visitors = { new SignInVisitor(), new IsSignedInVisitor(), new ToNowInTheatersVisitor(),
                                                  new CartoonGenreVisitor(), new SelectFirstCinema(), new SelectCinemaTodayDate(),
                                                  new SelectFirstAvailableTime(), new SelectOneStandartTicket(), new TapBuyTicketButton(),
                                                  new SelectAnySeatVisitor(), new PayWithCardVisitor() };

        private BaseVisitor[] test9Visitors = { new SelectCardVisitor(), new FinishCardReview() };

        private BaseVisitor[] test10Visitors = { new Wait15Minutes(), new DismissAlert() };

        private BaseVisitor[] test11Visitors = { new ToNowInTheatersVisitor(), new SelectFirstCinema(), new RateCinema() };

        private BaseVisitor[] test12Visitors = { new OpenMyProfileVisitor(), new UpdateProfileAddress(), new SaveChanges() };

        private BaseVisitor[] test13Visitors = { new CinamArenaCity(), new TapAnyCinemaPhoto() };

        private BaseVisitor[] test14Visitors = { new EnterCinemaToFind() };

        [OneTimeSetUpAttribute]
        public void Init()
        {
            DriverInstance.GetInstance().Navigate().GoToUrl(Tests.BASE_URL);
            PageFactory.InitElements(DriverInstance.GetInstance(), this);

            Thread.Sleep(2000);
            try
            {
                new IsSignedInVisitor().visit(DriverInstance.GetInstance());
                new SignOutVisitor().visit(DriverInstance.GetInstance());
            }
            catch
            {

            }
        }

        [OneTimeTearDownAttribute]
        public void Cleanup()
        {

            DriverInstance.GetInstance().Close();
        }

        /*
         * 2. Вход в свой аккаунт. ( перед эти нажав выйти)
         * 1) Нажимаем Войти.
         * 2) Вводим логин: albinushka674, вводим пароль: qazwsx12345. И нажимаем на галочку.
         * 3) В результате зашел на созданный профиль.
         */
        [TestCase]
        public void Test1()
        {
            this.visitWithVisitors(this.signInTestVisitors);
        }

        /*
         * 3. Выбор жанра.
         * 1) Нажимаем Афиша.
         * 2) Билеты в продаже.
         * 3) Выбираем кинотеатр Galileo.
         * 4) Выбираем Жанр Драма.
         * 5) В результате выведены все фильмы жанра драмма.
         */
        [TestCase]
        public void Test2()
        {
            this.visitWithVisitors(this.afishaGenreTestVisitors);
        }

        /*
         * 4. Проверка сортировки фильмов жанра Драмма. (Алфавитный по возрастанию)
         * 1) Нажимаем на кнопку со стрелочкой вниз, по шкале которая изображена на этой кнопке определяем тип сортировки по убыванию или по возрастанию.
         * 2) Выбираем по возрастанию.
         * 3) Есть два вида сортировки : Алфавитный, Дата выпуска. Выбираем Алфавитный.
         * 4) В результате получили список фильмов жанра драмма, отсортированных по возрастанию в алфавитном порядке.
         */
        [TestCase]
        public void Test3()
        {
            this.visitWithVisitors(this.alphabetAscendingTestVisitors);
        }

        /*
         * 5. Проверка сортировки фильмов жанра Драмма. (Алфавитный по убыванию)
         * 1) Нажимаем на кнопку со стрелочкой вниз, по шкале которая изображена на этой кнопке определяем тип сортировки по убыванию или по возрастанию.
         * 2) Выбираем по убыванию.
         * 3) Есть два вида сортировки : Алфавитный, Дата выпуска. Выбираем Алфавитный.
         * 4) В результате получили список фильмов жанра драмма, отсортированных поубыванию в алфавитном порядке.
         */
        [TestCase]
        public void Test4()
        {
            this.visitWithVisitors(this.alphabetDescendingTestVisitors);
        }

        /*
         * 6. Проверка сортировки фильмов жанра Драмма. (По дате выпуска по возрастанию)
         * 1) Нажимаем на кнопку со стрелочкой вниз, по шкале которая изображена на этой кнопке определяем тип сортировки по убыванию или по возрастанию.
         * 2) Выбираем по возрастанию.
         * 3) Есть два вида сортировки : Алфавитный, Дата выпуска. Выбираем Дата выпуска.
         * 4) В результате получили список фильмов жанра драмма, отсортированных по возрастанию по дате выпуска.
         */
        [TestCase]
        public void Test5()
        {
            this.visitWithVisitors(this.dateAscendingTestVisitors);
        }

        /*
         * 7. 6. Проверка сортировки фильмов жанра Драмма. (По дате выпуска по убыванию)
         * 1) Нажимаем на кнопку со стрелочкой вниз, по шкале которая изображена на этой кнопке определяем тип сортировки по убыванию или по возрастанию.
         * 2) Выбираем по убыванию.
         * 3) Есть два вида сортировки : Алфавитный, Дата выпуска. Выбираем Дата выпуска.
         * 4) В результате получили список фильмов жанра драмма, отсортированных по убыванию по дате выпуска.
         *
         */
        [TestCase]
        public void Test6()
        {
            this.visitWithVisitors(this.dateDescendingTestVisitors);
        }

        /*
         * 8. Выбор фильма и сеанса.
         * 1) Нажимаем на первый фильм из списка.
         * 2) Выбираем кинотеатр Galileo.
         * 3) Выбираем завтрашнюю дату.
         * 4) Выбираем ближайшее доступное время, нажав напротив него кнопку Выберите сеанс.
         * 5) В результате Выводится страница с выбором билетов и их количеством.
         */
        [TestCase]
        public void Test7()
        {
            this.visitWithVisitors(this.test7Visitors);
        }

        /*
         * 9. Покупка билета.
         * 1) На странице с выбором билетов и их количеством, можно выбрать 2 вида билетов: Стандартный и Love Seat.
         * 2) Выберем стандартный билет.
         * 3) В поле, напротив надписи Стандартный, в котором изначально стоит ноль, нажимаем на него и выбираем 1.
         * 4) Нажимаем кнопку Купить билеты.
         * 5) Появляется страница с выбором места.
         * 6) Jcnfdkztv оставляем предложенное место.
         * 7) Нажимаем подтвердить места.
         * 8) Нажимаем оплатить банковской карточкой.
         */
        [TestCase]
        public void Test8()
        {
            this.visitWithVisitors(this.test8Visitors);
        }

        /*
         * 10. Выбор карты, для оплаты и проверка суммы со скидкой.
         * 1) Сайт предлогает нам выбор оплаты с помощью трёх карт: Visa Gold LIVE - скидка 5%, Visa Platinum LIVE - скидка 10%, 
         * Visa Infinite Live - скидка 15%.
         * 2)Выбираем карту Visa Gold LIVE - скидка 5%.
         * 3)Открывается в новой вкладке страница с двумя полями: Сумма к оплате и Продолжить.
         * 4)В результате в поле "сумма к оплате со скидкой", выводится сумма со скидклй 5%.
         */
        [TestCase]
        public void Test9()
        {
            this.visitWithVisitors(this.test9Visitors);
        }

        /*
         * 11. Корзина.
         * 1) После выбора фильма и места билет помещается в корзину.
         * 2) В корзине билет может находиться 15 минут.
         * 3) после истечения 15 минут, если билет не был куплен, он удаляется из корзины.
         * 4)В результате появляется надпись Время резервации билетов истекло.
         */
        //[TestCase]
        public void Test91()
        {
            this.visitWithVisitors(this.test10Visitors);
        }

        /*
         * 12. Оценка фильма.
         * 1) В меню Выбираем Афиша, Билеты в продаже.
         * 2) Из появившегося списка фильмов, выбираем тот, который хотим оценить.
         * 3) Выбираем к примеру Аисты, нажимаем на название, перехрдим на страницу с его описанием.
         * 4) Под трейлером можно оценить фильм от 1 до 5 звёзд.
         * 5) Оцениваем в 5 звёзд.
         * 6) В результате пустые звёздочки закрашиваются и мы больше не можем оценить фильм и не можем изменить оценку, но, обновив  страницу, мы можем опять оценить фильм (хотя, так быть не должно).
         */
        [TestCase]
        public void Test92()
        {
            try
            {
                new IsSignedInVisitor().visit(DriverInstance.GetInstance());
            }
            catch
            {
                new SignInVisitor().visit(DriverInstance.GetInstance());
                Thread.Sleep(1000);
            }

            this.visitWithVisitors(this.test11Visitors);
        }

        /*
         * 13. Мой профиль.
         * 1) После того, как залогинились, мы переходим автоматически на страницу своего профиля. Так же попасть на свой профиль можно  нажав на своё имя и фамилию в правом верхем углу и после этого нажать Мой профиль.
         * 2) Там находится информация, которую можно дополнить или удалить, а так же нам находится статистика Количество приобретенных  билетов за последние 365 дней.
         * 3) В зависимости от этого количества определяется ваш уровень.
         * 4) После каждого изменения информации в профиле, нужно нажимать Сохранить профиль.
         */
        [TestCase]
        public void Test93()
        {
            try
            {
                new IsSignedInVisitor().visit(DriverInstance.GetInstance());
            }
            catch
            {
                new SignInVisitor().visit(DriverInstance.GetInstance());
                Thread.Sleep(1000);
            }

            this.visitWithVisitors(this.test12Visitors);
        }

        /*
         * 14. Галерея.
         * 1) Нажимаем в меню Кинотеатры, ARENAcity, мотаем вниз, видим Фотогалерея. 
         * 2) Нажимаем на любую фотографию, она открывается,  но переключиться на следующую фотографию, можно только вернувшись на предыдущую страницу и выбрать следующую фотографию, которую хотим посмотреть.
         */
        [TestCase]
        public void Test94()
        {
            this.visitWithVisitors(this.test13Visitors);
        }

        /*
         * 15. Поиск.
         * 1) В правом верхнем углу находится поиск.
         * 2) Вводим туда фильм который хотим найти, Моана и нажимаем на лупу. 
         * 3) Выводится результат поиска,фильм Бриджит Моана, если такой имеется.
         */
        [TestCase]
        public void Test95()
        {
            this.visitWithVisitors(this.test14Visitors);
        }

        private void visitWithVisitors(BaseVisitor[] visitors)
        {
            foreach (BaseVisitor visitor in visitors)
            {
                visitor.visit(DriverInstance.GetInstance());

                Thread.Sleep(1500);
            }
        }

    }

}