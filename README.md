# API

## Introduction 

		El servicio de arrendadora permitir leer la lista de automóviles disponibles para rentar, 
		leer la lista de ordenes de alquiler de autos, crear una orden de alquiler para un automóvil 
		disponible, leer la lista de categorías (tipos ex. van, sedan , etc.)  de automóviles y 
		actualizar, crear o eliminar categorías.

## Overview

		El framework utilizado es ASP .NET Core 3.1, base de datos MSSQL Express y editor VS Code.
		Paquetes requeridos: AutoMapper 10.1.1, 
		AutoMapper.Extensions.Microsoft.DependencyInjection 8.1,
		Microsoft.EntityFrameworkCore.SqlServer 3.1.9 .
		Connection string para la base de datos se configura en el archivo appsettings.json

## Endpoints

		[GET]http://localhost:5000/api/automobiles

		[GET]http://localhost:5000/api/categories

		[POST]http://localhost:5000/api/categories

		[PUT]http://localhost:5000/api/categories

		[DELETE]http://localhost:5000/api/categories

		[GET]http://localhost:5000/api/orders

		[POST]http://localhost:5000/api/orders


## POST Structures

### Orders

		{
			"FirstName": "Carlos",
			"LastName": "Perez",
			"Phone": "12345678",
			"OrderDate": "2020-12-25",
			"AutomobileId": 3
		}
		
	
### Categories

		{
			"Name": "Luxury",
		}
