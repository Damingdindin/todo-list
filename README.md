# TodoList 專案

### 簡介
這是一個基於 **ASP.NET Core MVC** 框架開發的 Todo List 應用程式，使用 **MySQL** 作為資料庫來存儲待辦事項。該專案還結合了 **jQuery**，實現了前端的動態交互功能，讓使用者能夠便捷地管理任務。

---

## 功能特色

- **待辦事項管理**：使用者可以新增、標記完成和查看任務清單，並顯示每個任務的完成狀態。
- **優先級設定**：每個任務都有高、中、低三個優先級別，使用者可以根據重要性對任務進行分類，並透過不同顏色顯示其優先級。
- **jQuery 動態互動**：
  - 使用 AJAX 新增任務，無需重新加載整個頁面。
  - 動態標記任務為完成，並自動更新任務清單。
  - 即時篩選待辦事項，依據已完成或未完成狀態進行顯示。

---

## 技術棧

- **前端**：
  - **HTML5**、**CSS3**、**jQuery**：實現頁面結構與動態效果。
  - **Bootstrap**：提供美觀的響應式 UI 結構。
  
- **後端**：
  - **ASP.NET Core MVC**：使用 MVC 模式進行後端開發，處理任務邏輯、控制器和數據庫交互。
  
- **資料庫**：
  - **MySQL**：作為後端資料庫，用於存儲和管理待辦事項資料。

---

## 如何運行該專案

### 1. 克隆專案

首先，克隆專案到你的本地端：

```bash
git clone https://github.com/your-repo/todolist.git
cd todolist


### 2. 安裝所需的依賴
運行以下命令來安裝專案所需的 NuGet 包：

```bash
dotnet restore
### 3. 設置 MySQL 資料庫
使用以下 SQL 語法在你的 MySQL 資料庫中創建所需的資料表：

```sql
CREATE DATABASE todolist;
USE todolist;

CREATE TABLE todos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Task VARCHAR(255) NOT NULL,
    IsCompleted BOOLEAN DEFAULT FALSE,
    Priority ENUM('Low', 'Medium', 'High') NOT NULL
);
### 4. 更新 appsettings.json
請確保在 appsettings.json 中配置了正確的 MySQL 資料庫連接字串。如下所示：
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=todolist;User Id=your_username;Password=your_password;"
  }
}

### 5.運行專案
使用以下指令運行專案：
```bash
dotnet build
dotnet run
