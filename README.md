# TodoList

## 簡介
這是一個基於 .NET Core MVC 開發的 Todo List 專案，使用 MySQL 作為資料庫。

## 如何運行

### 1. 克隆專案

```bash
git clone https://github.com/your-repo/todolist.git
cd todolist


###2. 設置資料庫

使用 MySQL Workbench 或命令行運行以下 SQL 來創建資料庫：
```bash
CREATE DATABASE todolist;
USE todolist;

CREATE TABLE todos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Task VARCHAR(255) NOT NULL,
    IsCompleted BOOLEAN DEFAULT FALSE,
    Priority ENUM('Low', 'Medium', 'High') NOT NULL
);
###3. 更新 appsettings.json
在 appsettings.json 中更新你的 MySQL 資料庫連接字串。

###4. 運行應用
```bash
dotnet build
dotnet run
