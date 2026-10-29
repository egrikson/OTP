# ER-диаграмма: учёт заказов в интернет-магазине электроники (вариант 27)

```mermaid
erDiagram
    CUSTOMER ||--o{ ORDER : "оформляет"
    ORDER ||--|{ ORDER_ITEM : "содержит"
    PRODUCT ||--o{ ORDER_ITEM : "входит в"
    SUPPLIER ||--o{ SUPPLY : "выполняет"
    PRODUCT ||--o{ SUPPLY : "поступает"

    PRODUCT {
        int Id PK
        string Name "модель"
        string Manufacturer "производитель"
        int Category "ProductCategory"
        int Features "ProductFeatures, флаги"
        decimal Price "цена"
    }
    CUSTOMER {
        int Id PK
        string FullName "ФИО"
        string Phone "телефон"
        string Email "эл. почта"
    }
    SUPPLIER {
        int Id PK
        string Name "название"
        string ContactPerson "контактное лицо"
        string Phone "телефон"
    }
    ORDER {
        int Id PK
        int CustomerId FK
        datetime OrderDate "дата заказа"
        int DeliveryType "DeliveryType"
        string DeliveryAddress "адрес доставки"
        int Status "OrderStatus"
    }
    ORDER_ITEM {
        int OrderId PK, FK
        int ProductId PK, FK
        int Count "количество"
        decimal Price "цена на момент заказа"
    }
    SUPPLY {
        int Id PK
        int SupplierId FK
        int ProductId FK
        int Count "количество"
        decimal PurchasePrice "закупочная цена"
        datetime SupplyDate "дата поставки"
    }
```

## Сущности

| Сущность | Тип | Назначение |
|---|---|---|
| Товар (`Product`) | справочник | каталог товаров с характеристиками и ценами |
| Клиент (`Customer`) | справочник | покупатели, оформляющие заказы |
| Поставщик (`Supplier`) | справочник | контрагенты, поставляющие товар на склад |
| Заказ (`Order`) | операция (создание, просмотр, удаление) | заказ клиента со способом получения и статусом |
| Позиция заказа (`OrderItem`) | связка | связь «многие-ко-многим» между заказами и товарами |
| Поставка (`Supply`) | операция (создание, просмотр) | поступление товара на склад от поставщика |

Справочники поддерживают полный набор CRUD. Дата операции и статус нового заказа («в обработке») проставляются автоматически.

Остаток товара на складе = сумма количеств по поставкам − сумма количеств по позициям заказов.

## Перечисления

- `ProductCategory` — категория товара: смартфоны, ноутбуки, планшеты, телевизоры, аудиотехника, аксессуары.
- `DeliveryType` — способ получения заказа: курьерская доставка или самовывоз.
- `OrderStatus` — статус заказа: в обработке, отправлен, доставлен.
- `ProductFeatures` (`[Flags]`) — набор характеристик товара: Wi-Fi, Bluetooth, NFC, 5G, GPS, влагозащита, беспроводная зарядка.
