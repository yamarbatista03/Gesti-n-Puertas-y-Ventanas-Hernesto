# Sistema de Gestión Operativa - Puertas y Ventanas Hernesto

## 🎯 Objetivo del Sistema
Desarrollar una aplicación de escritorio robusta para automatizar el control de operaciones, la gestión de inventario de materiales (aluminio, vidrio, herrajes), el registro de clientes y el cálculo automático de cotizaciones por metros cuadrados en un taller de carpintería metálica.

## ❓ Problema que Resuelve
Elimina los cálculos manuales propensos a errores y los retrasos en la elaboración de presupuestos para los clientes. Centraliza el control de stock de materiales, el registro de proyectos y la asignación de herramientas a los técnicos de obra.

## ⚙️ Funcionalidades Principales
- Módulo de gestión y registro de clientes.
- Módulo de cálculo automático de cotizaciones basadas en dimensiones y perfiles.
- Control de inventario de entradas y salidas de materiales.
- Asignación de herramientas a técnicos y seguimiento de proyectos.

## 🏛️ Arquitectura Seleccionada
El sistema está construido bajo una **Arquitectura en 3 Capas**:
1. **Capa de Presentación (UI):** Interfaces gráficas desarrolladas en C# Windows Forms (`FrmCotizador`, `FrmClientes`).
2. **Capa de Lógica de Negocio (BLL):** Contiene las reglas del negocio, validaciones y algoritmos de cálculo.
3. **Capa de Acceso a Datos (DAL):** Gestiona la conexión y ejecución de consultas y Stored Procedures hacia la base de datos relacional.

## 🗄️ Organización Frontend / Backend (Escritorio / Servidor de Datos)
Aunque el sistema opera como una aplicación de escritorio en C# con arquitectura local de 3 capas, funcionalmente se divide de la siguiente manera:
- **Frontend (Capa de Presentación - UI):** Es la interfaz visual con la que interactúa el usuario en el taller (formularios Windows Forms). Se encarga de capturar las medidas de las ventanas, datos de clientes y mostrar los resultados de las cotizaciones.
- **Backend y Base de Datos (BLL + DAL + SQL Server):** El backend procesa las reglas de negocio (cálculos de materiales y precios) y el motor de **SQL Server** actúa como gestor de base de datos persistente.
- **Comunicación:** El Frontend se comunica con el Backend mediante llamadas directas a clases y métodos de la BLL/DAL, las cuales a su vez interactúan con SQL Server mediante cadenas de conexión seguras y consultas parametrizadas.

## 🛠️ Herramientas Utilizadas
- **Lenguaje:** C# (.NET Framework / .NET)
- **Base de Datos:** Microsoft SQL Server
- **Control de Versiones:** Git y GitHub
- **Gestión de Proyectos:** GitHub Projects e Issues
- **Modelado UML:** Visual Paradigm Online

## 📊 Estado Actual del Proyecto
Proyecto en fase de estabilización y pruebas del módulo de cotizaciones automáticas, con el tablero de GitHub Projects actualizado al cierre técnico de la asignatura.
