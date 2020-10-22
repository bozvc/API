# API

## Introduction 

		El servicio de arrendadora permitir leer las lista de automobiles disponibles para rentar, 
		leer la lista de ordenes de alquiler de autos, crear una orden de alquiler para un automobil 
		disponible, leer las lista de categorias (tipos ex. van, sedan , etc.)  de automobiles y 
		actualizar, crear o eliminar categorias.

## Overview

		El framework utilizado es ASP .NET Core 3.1, basde de datos MSSQL Express y editor VS Code.
		Paquetes requeridos: AutoMapper 10.1.1, 
		AutoMapper.Extensions.Microsoft.DependencyInjection 8.1,
		Microsoft.EntityFrameworkCore.SqlServer 3.1.9 .

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
