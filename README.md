# BlazorTraining

## .razor
- Blazorのページを構成するファイル
- コンパイル時にクラスに変換される e.g. `App_razor.g.cs`


## EntityFrameworkCore
- コードファースト

```bash
$ Add-Migration Init
```

```bash
$ Update-Database
```

## EditForm 
Blazor備え付けのフォームコンポーネント
```cs
<EditForm Model="this.newStockItem" OnValidSubmit="OnOkAsync">
    <DataAnnotationsValidator />
    <div>
        品名 <input class="form-control" type="text" @bind="newStockItem.Name" />
    </div>
    <div>
        ロット番号 <input class="form-control" type="text" @bind="newStockItem.LotNumber" />
    </div>
    <div>
        数量 <input class="form-control" type="number" @bind="newStockItem.Quantity" />
    </div>
    <div>
        入庫日 <input class="form-control" type="date" @bind="newStockItem.ArrivalDate" />
    </div>

    <ValidationSummary />
    <button class="btn btn-primary">追加</button>
    <button class="btn btn-primary" @onclick="OnCancelAsync">キャンセル</button>
</EditForm>
```
- [EditFormクラス](https://learn.microsoft.com/ja-jp/dotnet/api/microsoft.aspnetcore.components.forms.editform?view=aspnetcore-8.0)
- [ASP.NET Core Blazor フォームの概要](https://learn.microsoft.com/ja-jp/aspnet/core/blazor/forms/?view=aspnetcore-8.0)

ASP.NET Core Blazor フォームの検証
- [DataAnnotationsValidator クラス](https://learn.microsoft.com/ja-jp/dotnet/api/microsoft.aspnetcore.components.forms.dataannotationsvalidator?view=aspnetcore-8.0)
- [ValidationSummary クラス](https://learn.microsoft.com/ja-jp/dotnet/api/microsoft.aspnetcore.components.forms.validationsummary?view=aspnetcore-8.0)