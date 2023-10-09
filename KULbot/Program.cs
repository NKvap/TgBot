using Telegram.Bot;
using System;
using Telegram.Bot.Types;
using System.Threading;
using Telegram.Bot.Types.Enums;

namespace KulinarBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TelegramBotClient("5838459323:AAHIeXQpvRhTQEEFOpYi_dPg8IRBNiX_FZY");
            client.StartReceiving(Update, Error);
            Console.ReadLine();
        }


        async static Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;
                
            if (message.Text == "Сендвич с курицей")
            {
                await client.SendPhotoAsync(
                chatId: message.From.Id,
                photo: InputFile.FromUri("https://yandex.ru/images/search?from=tabbar&img_url=https%3A%2F%2Fscontent-hel3-1.cdninstagram.com%2Fv%2Ft51.2885-15%2Fe35%2F136797086_401883507768867_8872168761759676083_n.jpg%3F_nc_ht%3Dscontent-hel3-1.cdninstagram.com%26_nc_cat%3D103%26_nc_ohc%3DF-V_6fJnUGIAX-Rk7RW%26edm%3DAABBvjUBAAAA%26ccb%3D7-4%26oh%3D3170a44d1af9307c99085820f2b2e8e7%26oe%3D61671950%26_nc_sid%3D83d603&lr=11184&pos=3&rpt=simage&text=сэндвич%20с%20курицей"));
                await client.SendTextMessageAsync(message.Chat.Id, "Сендвич с курицей\n" +
                    "\n" +
                    "ИНГРЕДИЕНТЫ:\n" +
                    "\n" + 
                    "Свежий хлеб для тостов - 2 шт\n" +
                    "Куриное филе - 1 шт\n" +
                    "Плавленный сыр - 2 шт\n" +
                    "Спелый помидор - 1 шт\n" +
                    "Маринованный огурец - 2 шт\n" +
                    "Томатный кетчуп - 1 ст л\n" +
                    "Соус-барбекю - 1 ст л\n" +
                    "Листья салата - 2 - 3 шт\n" +
                    "\n" +
                    "ПРИГОТОВЛЕНИЕ:\n" +
                    "\n" +
                    "Начнём с хлеба. нужно взять сковородку, рзогреть и поместить на неё хлеб, он должен стать хрустящим, но не сгреть, это достигается за пару минут.\n" +
                    "\n" +
                    "Куриное филе солим перчим по вкусу, посыпаем паприкой и оставляем мариноваться на 15 минут. Затем выкладываем на ту же сковороду, что и хлеб, заранее помазаной маслом и обжариваем с двух сторон до готовности.\n" +
                    "\n" +
                    "Начинаем сбор сендвича, берём хлеб, мажем с одной стороны кетчупом и выкладываем сверху лист салата, затем тонко нарезанный помидор, сыр, нарезанное куриное филе, затем опять сыр, выкладываем нарезанные солёные огурцы, опять листья салата и второй кусочек хлеба, смазанный соусом-барбекю.\n" +
                    "\n" +
                    "Остаётся разрезать так, чтобы получилость 2 треугольника и наслождаться вкусом!\n" +
                    "\n" +
                    "Приятного аппетита!\n");
                return;
            }
            
            if (message.Text == "Омлет с беконом")
            {
                await client.SendPhotoAsync(
                chatId: message.From.Id,
                photo: InputFile.FromUri("https://yandex.ru/images/search?from=tabbar&img_url=https%3A%2F%2Fglamours.name%2Fuploads%2Fposts%2F2023-08%2F1692286539_glamours-name-p-amerikanskii-variant-yaichnitsi-boltuni-vk-30.jpg&lr=11184&pos=15&rpt=simage&text=Омлет%20с%20беконом"));
                await client.SendTextMessageAsync(message.Chat.Id, "Омлет с беконом\n" +
                    "\n" +
                    "ИНГРЕДИЕНТЫ:\n" +
                    "\n" +
                    "Бекон - 100 гр\n" +
                    "Молоко - 50 мл\n" +
                    "Яйца - 4 шт\n" +
                    "Растительное масло - 1 ст л\n" +
                    "\n" +
                    "ПРИГОТОВЛЕНИЕ:\n" +
                    "\n" +
                    "Яйца помойте в тёплой воде с содой, так как на их поверхности могут находиться вредные бактерии. Разбейте их в глубокую миску и влейте молоко, посолите и поперчите. Размешайте венчиком или вилкой до однородности.\n" +
                    "\n" +
                    "В сковороде раскалите растительное масло. Выложите бекон. Если у вас он жирный, масла можете либо вообще не использовать, либо сократить его количество. Обжарьте с двух сторон до румяной корочки примерно по 2 минуты с каждой стороны.\n" +
                    "\n" +
                    "Вылейте в бекон яично-молочную смесь. Жарьте омлет на небольшом огне под крышкой около 8 минут.\n" +
                    "\n" +
                    "Приятного аппетита!\n");
                return;
            }
            
            if (message.Text == "Паста с креветками")
            {
                await client.SendPhotoAsync(
                chatId: message.From.Id,
                photo: InputFile.FromUri("https://yandex.ru/images/search?from=tabbar&img_url=https%3A%2F%2Fscontent-hel3-1.cdninstagram.com%2Fv%2Ft51.2885-15%2Fe35%2Fs1080x1080%2F272844545_1558733197841193_8240579788144398748_n.jpg%3F_nc_ht%3Dscontent-hel3-1.cdninstagram.com%26_nc_cat%3D109%26_nc_ohc%3DrwKBlKkRB7EAX9_baEh%26edm%3DABfd0MgBAAAA%26ccb%3D7-4%26oh%3D00_AT_GQU-HQTha9QligKzokfOjZx5LvnJaXg1zIFrU6sxyNQ%26oe%3D620086A8%26_nc_sid%3D7bff83&lr=11184&pos=2&rpt=simage&text=паста%20с%20креветками"));
                await client.SendTextMessageAsync(message.Chat.Id, "Паста с креветками\n" +
                    "\n" +
                    "ИНГРЕДИЕНТЫ:\n" +
                    "\n" +
                    "Креветки - 200 гр\n" +
                    "Паста - 2-3 клубка\n" +
                    "Сливки 15% - 150 мл\n" +
                    "Лук-порей - 0,5 шт\n" +
                    "Масло сливочное - 50 г\n" +
                    "Масло растительное - 0,5 ч. л. (для варки пасты)\n" +
                    "Сыр пармезан - 50 г\n" +
                    "\n" +
                    "ПРИГОТОВЛЕНИЕ:\n" +
                    "\n" +
                    "В небольшом количестве подсоленной воды с добавлением 0,5 ч. л. растительного масла отварите пасту в течение 5-7 минут, но не больше, чтобы она не разварилась. Масло не даст пасте склеиться.\n" +
                    "\n" +
                    "В это же время очистите креветки от панцирей, промойте их в воде. Растопите на сковороде сливочное масло, поместив ее на плиту. Добавьте в масло очищенные креветки и обжаривайте около 2-3\n" +
                    "\n" +
                    "Нарежьте зеленую часть лука-порея и добавьте ее к креветкам, протомите 1 минуту и залейте сливками. Всыпьте соль и молотый черный перец, потушите креветки в сливках около 2 минут.\n" +
                    "\n" +
                    "Добавьте отваренную пасту и еще минуту протомите блюдо на минимальном нагреве.\n" +
                    "\n" +
                    "Выложите пасту с креветками в сливочном соусе на тарелки, при желании посыпьте измельченным пармезаном и украсьте свежей зеленью.\n" +
                    "\n" +
                    "Приятного аппетита!\n");
                return;
            }

            if (message.Text != null)
            {
                await client.SendTextMessageAsync(message.Chat.Id, "Выбери рецепт!\n" +
                    "<<Напишите его название в сообщении>>");
                await client.SendTextMessageAsync(message.Chat.Id, "Сендвич с курицей;\n" +
                    "Омлет с беконом;\n" +
                    "Паста с креветками.");
                return;
            }
        }
        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}