create table HeaderDetails(
	InvoiceNumber int,
	CustomerInvoice int,
	RejectedUnits int,
	RecivedUnits int,
	RecivedAmounts money
	Primary Key(InvoiceNumber)
)

create table ItemDetails(
	ItemsDescription varchar(20),
	BatchCode int,
	Recived int ,
	PriceInfo money,
	InvoiceNumber int,
	AdditionalInfo varchar(50)
	Primary Key(BatchCode)
)

create table InventoryItem(
	ItemDecription varchar(20),
	ItemId int,
	BatchCode int,
	Inventory int,
	UnitPrice money
	Primary Key(ItemId)

)