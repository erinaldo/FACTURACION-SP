
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/16/2018 15:18:30
-- Generated from EDMX file: C:\Users\Walter Alonso\Desktop\SisSodIna\DataLayer\dbSisSodInaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbSisSodIna];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_tbAbonos_tbCreditos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbAbonos] DROP CONSTRAINT [FK_tbAbonos_tbCreditos];
GO
IF OBJECT_ID(N'[dbo].[FK_tbCajaUsuario_tbCajas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbCajaUsuario] DROP CONSTRAINT [FK_tbCajaUsuario_tbCajas];
GO
IF OBJECT_ID(N'[dbo].[FK_tbCajaUsuario_tbUsuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbCajaUsuario] DROP CONSTRAINT [FK_tbCajaUsuario_tbUsuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_tbCajaUsuMonedas_tbCajaUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbCajaUsuMonedas] DROP CONSTRAINT [FK_tbCajaUsuMonedas_tbCajaUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tbCajaUsuMonedas_tbMonedas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbCajaUsuMonedas] DROP CONSTRAINT [FK_tbCajaUsuMonedas_tbMonedas];
GO
IF OBJECT_ID(N'[dbo].[FK_tbCliente_tbPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbClientes] DROP CONSTRAINT [FK_tbCliente_tbPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_tbClientes_tbTipoClientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbClientes] DROP CONSTRAINT [FK_tbClientes_tbTipoClientes];
GO
IF OBJECT_ID(N'[dbo].[FK_tbCreditos_tbClientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbCreditos] DROP CONSTRAINT [FK_tbCreditos_tbClientes];
GO
IF OBJECT_ID(N'[dbo].[FK_tbCreditos_tbMovimientos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbCreditos] DROP CONSTRAINT [FK_tbCreditos_tbMovimientos];
GO
IF OBJECT_ID(N'[dbo].[FK_tbDetalleFactura_tbFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbDetalleFactura] DROP CONSTRAINT [FK_tbDetalleFactura_tbFactura];
GO
IF OBJECT_ID(N'[dbo].[FK_tbDetalleFactura_tbProducto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbDetalleFactura] DROP CONSTRAINT [FK_tbDetalleFactura_tbProducto];
GO
IF OBJECT_ID(N'[dbo].[FK_tbDetalleMovimiento_tbIngredientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbDetalleMovimiento] DROP CONSTRAINT [FK_tbDetalleMovimiento_tbIngredientes];
GO
IF OBJECT_ID(N'[dbo].[FK_tbDetalleMovimiento_tbMovimientos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbDetalleMovimiento] DROP CONSTRAINT [FK_tbDetalleMovimiento_tbMovimientos];
GO
IF OBJECT_ID(N'[dbo].[FK_tbDetalleProducto_tbIngredientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbDetalleProducto] DROP CONSTRAINT [FK_tbDetalleProducto_tbIngredientes];
GO
IF OBJECT_ID(N'[dbo].[FK_tbDetalleProducto_tbProducto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbDetalleProducto] DROP CONSTRAINT [FK_tbDetalleProducto_tbProducto];
GO
IF OBJECT_ID(N'[dbo].[FK_tbEmpleado_tbPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbEmpleado] DROP CONSTRAINT [FK_tbEmpleado_tbPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_tbEmpleado_tbTipoPuesto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbEmpleado] DROP CONSTRAINT [FK_tbEmpleado_tbTipoPuesto];
GO
IF OBJECT_ID(N'[dbo].[FK_tbFactura_tbClientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbFactura] DROP CONSTRAINT [FK_tbFactura_tbClientes];
GO
IF OBJECT_ID(N'[dbo].[FK_tbHorarioProveedor_tbProveedores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbHorarioProveedor] DROP CONSTRAINT [FK_tbHorarioProveedor_tbProveedores];
GO
IF OBJECT_ID(N'[dbo].[FK_tbIngredienteProveedor_tbIngredientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbIngredienteProveedor] DROP CONSTRAINT [FK_tbIngredienteProveedor_tbIngredientes];
GO
IF OBJECT_ID(N'[dbo].[FK_tbIngredienteProveedor_tbProveedores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbIngredienteProveedor] DROP CONSTRAINT [FK_tbIngredienteProveedor_tbProveedores];
GO
IF OBJECT_ID(N'[dbo].[FK_tbIngredientes_tbTipoIngrediente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbIngredientes] DROP CONSTRAINT [FK_tbIngredientes_tbTipoIngrediente];
GO
IF OBJECT_ID(N'[dbo].[FK_tbIngredientes_tbTipoMedidas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbIngredientes] DROP CONSTRAINT [FK_tbIngredientes_tbTipoMedidas];
GO
IF OBJECT_ID(N'[dbo].[FK_tbInventario_tbIngredientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbInventario] DROP CONSTRAINT [FK_tbInventario_tbIngredientes];
GO
IF OBJECT_ID(N'[dbo].[FK_tbMonedas_tbTipoMoneda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbMonedas] DROP CONSTRAINT [FK_tbMonedas_tbTipoMoneda];
GO
IF OBJECT_ID(N'[dbo].[FK_tbMovimientoCajaUsuario_tbCajaUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbMovimientoCajaUsuario] DROP CONSTRAINT [FK_tbMovimientoCajaUsuario_tbCajaUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tbMovimientoCajaUsuario_tbMovimientos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbMovimientoCajaUsuario] DROP CONSTRAINT [FK_tbMovimientoCajaUsuario_tbMovimientos];
GO
IF OBJECT_ID(N'[dbo].[FK_tbMovimientos_tbTipoMovimiento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbMovimientos] DROP CONSTRAINT [FK_tbMovimientos_tbTipoMovimiento];
GO
IF OBJECT_ID(N'[dbo].[FK_tbPagos_tbEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbPagos] DROP CONSTRAINT [FK_tbPagos_tbEmpleado];
GO
IF OBJECT_ID(N'[dbo].[FK_tbPagos_tbMovimientos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbPagos] DROP CONSTRAINT [FK_tbPagos_tbMovimientos];
GO
IF OBJECT_ID(N'[dbo].[FK_tbPermisos_tbRequerimientos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbPermisos] DROP CONSTRAINT [FK_tbPermisos_tbRequerimientos];
GO
IF OBJECT_ID(N'[dbo].[FK_tbPermisos_tbRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbPermisos] DROP CONSTRAINT [FK_tbPermisos_tbRoles];
GO
IF OBJECT_ID(N'[dbo].[FK_tbProducto_tbCategoriaProducto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbProducto] DROP CONSTRAINT [FK_tbProducto_tbCategoriaProducto];
GO
IF OBJECT_ID(N'[dbo].[FK_tbProveedores_tbPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbProveedores] DROP CONSTRAINT [FK_tbProveedores_tbPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_tbUsuarios_tbPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbUsuarios] DROP CONSTRAINT [FK_tbUsuarios_tbPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_tbUsuarios_tbRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbUsuarios] DROP CONSTRAINT [FK_tbUsuarios_tbRoles];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[tbAbonos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbAbonos];
GO
IF OBJECT_ID(N'[dbo].[tbCajas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbCajas];
GO
IF OBJECT_ID(N'[dbo].[tbCajaUsuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbCajaUsuario];
GO
IF OBJECT_ID(N'[dbo].[tbCajaUsuMonedas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbCajaUsuMonedas];
GO
IF OBJECT_ID(N'[dbo].[tbCategoriaProducto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbCategoriaProducto];
GO
IF OBJECT_ID(N'[dbo].[tbClientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbClientes];
GO
IF OBJECT_ID(N'[dbo].[tbCreditos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbCreditos];
GO
IF OBJECT_ID(N'[dbo].[tbDetalleFactura]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDetalleFactura];
GO
IF OBJECT_ID(N'[dbo].[tbDetalleImpresion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDetalleImpresion];
GO
IF OBJECT_ID(N'[dbo].[tbDetalleMovimiento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDetalleMovimiento];
GO
IF OBJECT_ID(N'[dbo].[tbDetalleProducto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDetalleProducto];
GO
IF OBJECT_ID(N'[dbo].[tbEmpleado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbEmpleado];
GO
IF OBJECT_ID(N'[dbo].[tbFactura]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbFactura];
GO
IF OBJECT_ID(N'[dbo].[tbHorarioProveedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbHorarioProveedor];
GO
IF OBJECT_ID(N'[dbo].[tbIngredienteProveedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbIngredienteProveedor];
GO
IF OBJECT_ID(N'[dbo].[tbIngredientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbIngredientes];
GO
IF OBJECT_ID(N'[dbo].[tbInventario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbInventario];
GO
IF OBJECT_ID(N'[dbo].[tbMonedas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMonedas];
GO
IF OBJECT_ID(N'[dbo].[tbMovimientoCajaUsuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMovimientoCajaUsuario];
GO
IF OBJECT_ID(N'[dbo].[tbMovimientos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMovimientos];
GO
IF OBJECT_ID(N'[dbo].[tbPagos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbPagos];
GO
IF OBJECT_ID(N'[dbo].[tbPermisos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbPermisos];
GO
IF OBJECT_ID(N'[dbo].[tbPersona]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbPersona];
GO
IF OBJECT_ID(N'[dbo].[tbProducto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbProducto];
GO
IF OBJECT_ID(N'[dbo].[tbProveedores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbProveedores];
GO
IF OBJECT_ID(N'[dbo].[tbRequerimientos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbRequerimientos];
GO
IF OBJECT_ID(N'[dbo].[tbRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbRoles];
GO
IF OBJECT_ID(N'[dbo].[tbTipoClientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbTipoClientes];
GO
IF OBJECT_ID(N'[dbo].[tbTipoIngrediente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbTipoIngrediente];
GO
IF OBJECT_ID(N'[dbo].[tbTipoMedidas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbTipoMedidas];
GO
IF OBJECT_ID(N'[dbo].[tbTipoMoneda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbTipoMoneda];
GO
IF OBJECT_ID(N'[dbo].[tbTipoMovimiento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbTipoMovimiento];
GO
IF OBJECT_ID(N'[dbo].[tbTipoPuesto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbTipoPuesto];
GO
IF OBJECT_ID(N'[dbo].[tbUsuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbUsuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'tbAbonos'
CREATE TABLE [dbo].[tbAbonos] (
    [idAbono] int IDENTITY(1,1) NOT NULL,
    [idCredito] int  NOT NULL,
    [monto] decimal(18,0)  NOT NULL,
    [motivo] nchar(500)  NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL,
    [estado] bit  NOT NULL
);
GO

-- Creating table 'tbCajas'
CREATE TABLE [dbo].[tbCajas] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [descripcion] nchar(500)  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbCajaUsuario'
CREATE TABLE [dbo].[tbCajaUsuario] (
    [id] int IDENTITY(1,1) NOT NULL,
    [idCaja] int  NOT NULL,
    [idUser] nchar(30)  NOT NULL,
    [tipoId] int  NOT NULL,
    [tipoMovCaja] int  NOT NULL,
    [fecha] datetime  NOT NULL,
    [total] int  NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL,
    [estado] bit  NOT NULL
);
GO

-- Creating table 'tbCajaUsuMonedas'
CREATE TABLE [dbo].[tbCajaUsuMonedas] (
    [idMoneda] int  NOT NULL,
    [idCajaUsuario] int  NOT NULL,
    [cantidad] int  NOT NULL,
    [subtotal] int  NOT NULL
);
GO

-- Creating table 'tbCategoriaProducto'
CREATE TABLE [dbo].[tbCategoriaProducto] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [descripcion] nchar(500)  NULL,
    [fotocategoria] nchar(2000)  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbClientes'
CREATE TABLE [dbo].[tbClientes] (
    [id] nchar(30)  NOT NULL,
    [tipoId] int  NOT NULL,
    [tipoCliente] int  NOT NULL,
    [descripcion] nchar(500)  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_crea] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbCreditos'
CREATE TABLE [dbo].[tbCreditos] (
    [idCredito] int IDENTITY(1,1) NOT NULL,
    [idCliente] nchar(30)  NOT NULL,
    [tipoCliente] int  NULL,
    [idMov] int  NOT NULL,
    [idEstado] bit  NOT NULL,
    [estadoCredito] bit  NOT NULL,
    [montoCredito] decimal(18,0)  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL,
    [saldoCredito] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'tbDetalleFactura'
CREATE TABLE [dbo].[tbDetalleFactura] (
    [id] int IDENTITY(1,1) NOT NULL,
    [idFactura] int  NOT NULL,
    [idProducto] varchar(50)  NOT NULL,
    [cantidad] int  NOT NULL,
    [precio] real  NOT NULL,
    [subtotal] real  NOT NULL
);
GO

-- Creating table 'tbDetalleImpresion'
CREATE TABLE [dbo].[tbDetalleImpresion] (
    [ID] int  NOT NULL,
    [NombreEmpresa] char(500)  NOT NULL,
    [TelefonoEmpresa] char(15)  NOT NULL,
    [DireccionEmpresa] nchar(1000)  NOT NULL,
    [MensajeTributacion] char(500)  NOT NULL,
    [MensajeDespedida] char(500)  NOT NULL,
    [LogoEmpresa] char(2000)  NOT NULL
);
GO

-- Creating table 'tbDetalleMovimiento'
CREATE TABLE [dbo].[tbDetalleMovimiento] (
    [idDetalleMov] int IDENTITY(1,1) NOT NULL,
    [idMov] int  NOT NULL,
    [idIngrediente] int  NOT NULL,
    [cantidad] int  NOT NULL,
    [monto] decimal(19,4)  NULL
);
GO

-- Creating table 'tbDetalleProducto'
CREATE TABLE [dbo].[tbDetalleProducto] (
    [id] int IDENTITY(1,1) NOT NULL,
    [idProducto] varchar(50)  NOT NULL,
    [idIngrediente] int  NOT NULL,
    [cantidad] real  NOT NULL
);
GO

-- Creating table 'tbEmpleado'
CREATE TABLE [dbo].[tbEmpleado] (
    [id] nchar(30)  NOT NULL,
    [tipoId] int  NOT NULL,
    [idPuesto] int  NOT NULL,
    [fecha_ingreso] datetime  NOT NULL,
    [fecha_salida] datetime  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_crea] nchar(30)  NOT NULL,
    [esContraDefinido] bit  NOT NULL,
    [direccion] nchar(500)  NULL
);
GO

-- Creating table 'tbFactura'
CREATE TABLE [dbo].[tbFactura] (
    [id] int IDENTITY(1,1) NOT NULL,
    [fecha] datetime  NOT NULL,
    [idCliente] nchar(30)  NULL,
    [tipoIdCliente] int  NULL,
    [tipoPago] int  NOT NULL,
    [refPago] nchar(30)  NULL,
    [descuento] real  NULL,
    [iva] real  NULL,
    [total] real  NOT NULL,
    [pago] real  NOT NULL,
    [estadoFactura] int  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL,
    [estado] bit  NOT NULL,
    [idCaja] int  NOT NULL,
    [alias] nchar(100)  NULL
);
GO

-- Creating table 'tbHorarioProveedor'
CREATE TABLE [dbo].[tbHorarioProveedor] (
    [idTipo] int  NOT NULL,
    [idProveedor] nchar(30)  NOT NULL,
    [idTipoHorario] int  NOT NULL,
    [lunes] bit  NULL,
    [martes] bit  NULL,
    [miercoles] bit  NULL,
    [jueves] bit  NULL,
    [viernes] bit  NULL,
    [sabado] bit  NULL,
    [domingo] bit  NULL
);
GO

-- Creating table 'tbIngredientes'
CREATE TABLE [dbo].[tbIngredientes] (
    [idIngrediente] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(50)  NOT NULL,
    [idTipoMedida] int  NOT NULL,
    [idTipoIngrediente] int  NOT NULL,
    [precioCompra] decimal(19,4)  NOT NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbInventario'
CREATE TABLE [dbo].[tbInventario] (
    [idInventario] int IDENTITY(1,1) NOT NULL,
    [idIngrediente] int  NOT NULL,
    [cantidad] float  NOT NULL,
    [cant_min] int  NULL,
    [cant_max] int  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbMonedas'
CREATE TABLE [dbo].[tbMonedas] (
    [idMoneda] int IDENTITY(1,1) NOT NULL,
    [moneda] nchar(10)  NOT NULL,
    [idTipoMoneda] int  NOT NULL,
    [estado] bit  NOT NULL
);
GO

-- Creating table 'tbMovimientos'
CREATE TABLE [dbo].[tbMovimientos] (
    [idMovimiento] int IDENTITY(1,1) NOT NULL,
    [fecha] datetime  NOT NULL,
    [idTipoMov] int  NOT NULL,
    [estado] bit  NOT NULL,
    [motivo] nchar(500)  NULL,
    [total] decimal(19,4)  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbPagos'
CREATE TABLE [dbo].[tbPagos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [idEmpleado] nchar(30)  NOT NULL,
    [tipoId] int  NOT NULL,
    [Cantidad_horas] int  NOT NULL,
    [cantidad_horaExtra] int  NULL,
    [total] real  NOT NULL,
    [fecha_pago] datetime  NOT NULL,
    [descripcion] nchar(500)  NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL,
    [idMovimiento] int  NOT NULL
);
GO

-- Creating table 'tbPersona'
CREATE TABLE [dbo].[tbPersona] (
    [tipoId] int  NOT NULL,
    [identificacion] nchar(30)  NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [apellido1] nchar(30)  NULL,
    [correo] nchar(30)  NULL,
    [apellido2] nchar(30)  NULL,
    [fechaNac] datetime  NULL,
    [sexo] int  NULL,
    [telefono] nchar(10)  NOT NULL
);
GO

-- Creating table 'tbProducto'
CREATE TABLE [dbo].[tbProducto] (
    [idProducto] varchar(50)  NOT NULL,
    [nombre] char(30)  NOT NULL,
    [id_categoria] int  NOT NULL,
    [precio_venta1] decimal(19,4)  NULL,
    [precio_venta2] decimal(19,4)  NULL,
    [precio_venta3] decimal(19,4)  NOT NULL,
    [utilidad1] int  NULL,
    [utilidad3] int  NULL,
    [utilidad2] int  NULL,
    [precio_real] decimal(18,0)  NULL,
    [precio_promo] decimal(19,4)  NULL,
    [esExento] bit  NULL,
    [esPromo] bit  NULL,
    [foto] char(2000)  NULL,
    [descuento_max] int  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbProveedores'
CREATE TABLE [dbo].[tbProveedores] (
    [id] nchar(30)  NOT NULL,
    [tipoId] int  NOT NULL,
    [representante] nchar(150)  NOT NULL,
    [telefono1] nchar(10)  NOT NULL,
    [telefono2] nchar(10)  NULL,
    [tipoPago] int  NOT NULL,
    [cuenta] nchar(30)  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbRequerimientos'
CREATE TABLE [dbo].[tbRequerimientos] (
    [idReq] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [descripcion] nchar(500)  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbRoles'
CREATE TABLE [dbo].[tbRoles] (
    [idRol] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [descripcion] nchar(500)  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbTipoClientes'
CREATE TABLE [dbo].[tbTipoClientes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(30)  NULL,
    [descripcion] varchar(500)  NULL,
    [estado] bit  NULL,
    [fecha_crea] datetime  NULL,
    [fecha_ult_mod] datetime  NULL,
    [usuario_crea] nchar(30)  NULL,
    [usuario_ult_mod] nchar(30)  NULL
);
GO

-- Creating table 'tbTipoIngrediente'
CREATE TABLE [dbo].[tbTipoIngrediente] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [descripcion] nchar(500)  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbTipoMedidas'
CREATE TABLE [dbo].[tbTipoMedidas] (
    [idTipoMedida] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [nomenclatura] char(3)  NOT NULL,
    [descripcion] nchar(500)  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbTipoMoneda'
CREATE TABLE [dbo].[tbTipoMoneda] (
    [id] int  NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [simbolo] nchar(1)  NOT NULL,
    [estado] bit  NOT NULL
);
GO

-- Creating table 'tbTipoMovimiento'
CREATE TABLE [dbo].[tbTipoMovimiento] (
    [idTipo] int  NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [descripcion] nchar(30)  NULL,
    [afecta_conta] smallint  NOT NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbTipoPuesto'
CREATE TABLE [dbo].[tbTipoPuesto] (
    [idTipoPuesto] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [descripcion] nchar(500)  NULL,
    [precio_hora] float  NULL,
    [precio_ext] float  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbUsuarios'
CREATE TABLE [dbo].[tbUsuarios] (
    [tipoId] int  NOT NULL,
    [id] nchar(30)  NOT NULL,
    [nombreUsuario] nchar(30)  NOT NULL,
    [contraseña] nchar(30)  NOT NULL,
    [idRol] int  NOT NULL,
    [foto_url] nchar(500)  NULL,
    [estado] bit  NOT NULL,
    [fecha_crea] datetime  NOT NULL,
    [fecha_ult_mod] datetime  NOT NULL,
    [usuario_crea] nchar(30)  NOT NULL,
    [usuario_ult_mod] nchar(30)  NOT NULL
);
GO

-- Creating table 'tbIngredienteProveedor'
CREATE TABLE [dbo].[tbIngredienteProveedor] (
    [tbIngredientes_idIngrediente] int  NOT NULL,
    [tbProveedores_id] nchar(30)  NOT NULL,
    [tbProveedores_tipoId] int  NOT NULL
);
GO

-- Creating table 'tbMovimientoCajaUsuario'
CREATE TABLE [dbo].[tbMovimientoCajaUsuario] (
    [tbCajaUsuario_id] int  NOT NULL,
    [tbMovimientos_idMovimiento] int  NOT NULL
);
GO

-- Creating table 'tbPermisos'
CREATE TABLE [dbo].[tbPermisos] (
    [tbRequerimientos_idReq] int  NOT NULL,
    [tbRoles_idRol] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [idAbono] in table 'tbAbonos'
ALTER TABLE [dbo].[tbAbonos]
ADD CONSTRAINT [PK_tbAbonos]
    PRIMARY KEY CLUSTERED ([idAbono] ASC);
GO

-- Creating primary key on [id] in table 'tbCajas'
ALTER TABLE [dbo].[tbCajas]
ADD CONSTRAINT [PK_tbCajas]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbCajaUsuario'
ALTER TABLE [dbo].[tbCajaUsuario]
ADD CONSTRAINT [PK_tbCajaUsuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [idMoneda], [idCajaUsuario] in table 'tbCajaUsuMonedas'
ALTER TABLE [dbo].[tbCajaUsuMonedas]
ADD CONSTRAINT [PK_tbCajaUsuMonedas]
    PRIMARY KEY CLUSTERED ([idMoneda], [idCajaUsuario] ASC);
GO

-- Creating primary key on [id] in table 'tbCategoriaProducto'
ALTER TABLE [dbo].[tbCategoriaProducto]
ADD CONSTRAINT [PK_tbCategoriaProducto]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id], [tipoId] in table 'tbClientes'
ALTER TABLE [dbo].[tbClientes]
ADD CONSTRAINT [PK_tbClientes]
    PRIMARY KEY CLUSTERED ([id], [tipoId] ASC);
GO

-- Creating primary key on [idCredito] in table 'tbCreditos'
ALTER TABLE [dbo].[tbCreditos]
ADD CONSTRAINT [PK_tbCreditos]
    PRIMARY KEY CLUSTERED ([idCredito] ASC);
GO

-- Creating primary key on [id], [idFactura] in table 'tbDetalleFactura'
ALTER TABLE [dbo].[tbDetalleFactura]
ADD CONSTRAINT [PK_tbDetalleFactura]
    PRIMARY KEY CLUSTERED ([id], [idFactura] ASC);
GO

-- Creating primary key on [ID] in table 'tbDetalleImpresion'
ALTER TABLE [dbo].[tbDetalleImpresion]
ADD CONSTRAINT [PK_tbDetalleImpresion]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [idDetalleMov], [idMov], [idIngrediente] in table 'tbDetalleMovimiento'
ALTER TABLE [dbo].[tbDetalleMovimiento]
ADD CONSTRAINT [PK_tbDetalleMovimiento]
    PRIMARY KEY CLUSTERED ([idDetalleMov], [idMov], [idIngrediente] ASC);
GO

-- Creating primary key on [id] in table 'tbDetalleProducto'
ALTER TABLE [dbo].[tbDetalleProducto]
ADD CONSTRAINT [PK_tbDetalleProducto]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id], [tipoId] in table 'tbEmpleado'
ALTER TABLE [dbo].[tbEmpleado]
ADD CONSTRAINT [PK_tbEmpleado]
    PRIMARY KEY CLUSTERED ([id], [tipoId] ASC);
GO

-- Creating primary key on [id] in table 'tbFactura'
ALTER TABLE [dbo].[tbFactura]
ADD CONSTRAINT [PK_tbFactura]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [idTipo], [idProveedor], [idTipoHorario] in table 'tbHorarioProveedor'
ALTER TABLE [dbo].[tbHorarioProveedor]
ADD CONSTRAINT [PK_tbHorarioProveedor]
    PRIMARY KEY CLUSTERED ([idTipo], [idProveedor], [idTipoHorario] ASC);
GO

-- Creating primary key on [idIngrediente] in table 'tbIngredientes'
ALTER TABLE [dbo].[tbIngredientes]
ADD CONSTRAINT [PK_tbIngredientes]
    PRIMARY KEY CLUSTERED ([idIngrediente] ASC);
GO

-- Creating primary key on [idInventario], [idIngrediente] in table 'tbInventario'
ALTER TABLE [dbo].[tbInventario]
ADD CONSTRAINT [PK_tbInventario]
    PRIMARY KEY CLUSTERED ([idInventario], [idIngrediente] ASC);
GO

-- Creating primary key on [idMoneda] in table 'tbMonedas'
ALTER TABLE [dbo].[tbMonedas]
ADD CONSTRAINT [PK_tbMonedas]
    PRIMARY KEY CLUSTERED ([idMoneda] ASC);
GO

-- Creating primary key on [idMovimiento] in table 'tbMovimientos'
ALTER TABLE [dbo].[tbMovimientos]
ADD CONSTRAINT [PK_tbMovimientos]
    PRIMARY KEY CLUSTERED ([idMovimiento] ASC);
GO

-- Creating primary key on [id] in table 'tbPagos'
ALTER TABLE [dbo].[tbPagos]
ADD CONSTRAINT [PK_tbPagos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [tipoId], [identificacion] in table 'tbPersona'
ALTER TABLE [dbo].[tbPersona]
ADD CONSTRAINT [PK_tbPersona]
    PRIMARY KEY CLUSTERED ([tipoId], [identificacion] ASC);
GO

-- Creating primary key on [idProducto] in table 'tbProducto'
ALTER TABLE [dbo].[tbProducto]
ADD CONSTRAINT [PK_tbProducto]
    PRIMARY KEY CLUSTERED ([idProducto] ASC);
GO

-- Creating primary key on [id], [tipoId] in table 'tbProveedores'
ALTER TABLE [dbo].[tbProveedores]
ADD CONSTRAINT [PK_tbProveedores]
    PRIMARY KEY CLUSTERED ([id], [tipoId] ASC);
GO

-- Creating primary key on [idReq] in table 'tbRequerimientos'
ALTER TABLE [dbo].[tbRequerimientos]
ADD CONSTRAINT [PK_tbRequerimientos]
    PRIMARY KEY CLUSTERED ([idReq] ASC);
GO

-- Creating primary key on [idRol] in table 'tbRoles'
ALTER TABLE [dbo].[tbRoles]
ADD CONSTRAINT [PK_tbRoles]
    PRIMARY KEY CLUSTERED ([idRol] ASC);
GO

-- Creating primary key on [id] in table 'tbTipoClientes'
ALTER TABLE [dbo].[tbTipoClientes]
ADD CONSTRAINT [PK_tbTipoClientes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbTipoIngrediente'
ALTER TABLE [dbo].[tbTipoIngrediente]
ADD CONSTRAINT [PK_tbTipoIngrediente]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [idTipoMedida] in table 'tbTipoMedidas'
ALTER TABLE [dbo].[tbTipoMedidas]
ADD CONSTRAINT [PK_tbTipoMedidas]
    PRIMARY KEY CLUSTERED ([idTipoMedida] ASC);
GO

-- Creating primary key on [id] in table 'tbTipoMoneda'
ALTER TABLE [dbo].[tbTipoMoneda]
ADD CONSTRAINT [PK_tbTipoMoneda]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [idTipo] in table 'tbTipoMovimiento'
ALTER TABLE [dbo].[tbTipoMovimiento]
ADD CONSTRAINT [PK_tbTipoMovimiento]
    PRIMARY KEY CLUSTERED ([idTipo] ASC);
GO

-- Creating primary key on [idTipoPuesto] in table 'tbTipoPuesto'
ALTER TABLE [dbo].[tbTipoPuesto]
ADD CONSTRAINT [PK_tbTipoPuesto]
    PRIMARY KEY CLUSTERED ([idTipoPuesto] ASC);
GO

-- Creating primary key on [tipoId], [id] in table 'tbUsuarios'
ALTER TABLE [dbo].[tbUsuarios]
ADD CONSTRAINT [PK_tbUsuarios]
    PRIMARY KEY CLUSTERED ([tipoId], [id] ASC);
GO

-- Creating primary key on [tbIngredientes_idIngrediente], [tbProveedores_id], [tbProveedores_tipoId] in table 'tbIngredienteProveedor'
ALTER TABLE [dbo].[tbIngredienteProveedor]
ADD CONSTRAINT [PK_tbIngredienteProveedor]
    PRIMARY KEY CLUSTERED ([tbIngredientes_idIngrediente], [tbProveedores_id], [tbProveedores_tipoId] ASC);
GO

-- Creating primary key on [tbCajaUsuario_id], [tbMovimientos_idMovimiento] in table 'tbMovimientoCajaUsuario'
ALTER TABLE [dbo].[tbMovimientoCajaUsuario]
ADD CONSTRAINT [PK_tbMovimientoCajaUsuario]
    PRIMARY KEY CLUSTERED ([tbCajaUsuario_id], [tbMovimientos_idMovimiento] ASC);
GO

-- Creating primary key on [tbRequerimientos_idReq], [tbRoles_idRol] in table 'tbPermisos'
ALTER TABLE [dbo].[tbPermisos]
ADD CONSTRAINT [PK_tbPermisos]
    PRIMARY KEY CLUSTERED ([tbRequerimientos_idReq], [tbRoles_idRol] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idCredito] in table 'tbAbonos'
ALTER TABLE [dbo].[tbAbonos]
ADD CONSTRAINT [FK_tbAbonos_tbCreditos]
    FOREIGN KEY ([idCredito])
    REFERENCES [dbo].[tbCreditos]
        ([idCredito])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbAbonos_tbCreditos'
CREATE INDEX [IX_FK_tbAbonos_tbCreditos]
ON [dbo].[tbAbonos]
    ([idCredito]);
GO

-- Creating foreign key on [idCaja] in table 'tbCajaUsuario'
ALTER TABLE [dbo].[tbCajaUsuario]
ADD CONSTRAINT [FK_tbCajaUsuario_tbCajas]
    FOREIGN KEY ([idCaja])
    REFERENCES [dbo].[tbCajas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbCajaUsuario_tbCajas'
CREATE INDEX [IX_FK_tbCajaUsuario_tbCajas]
ON [dbo].[tbCajaUsuario]
    ([idCaja]);
GO

-- Creating foreign key on [tipoId], [idUser] in table 'tbCajaUsuario'
ALTER TABLE [dbo].[tbCajaUsuario]
ADD CONSTRAINT [FK_tbCajaUsuario_tbUsuarios]
    FOREIGN KEY ([tipoId], [idUser])
    REFERENCES [dbo].[tbUsuarios]
        ([tipoId], [id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbCajaUsuario_tbUsuarios'
CREATE INDEX [IX_FK_tbCajaUsuario_tbUsuarios]
ON [dbo].[tbCajaUsuario]
    ([tipoId], [idUser]);
GO

-- Creating foreign key on [idCajaUsuario] in table 'tbCajaUsuMonedas'
ALTER TABLE [dbo].[tbCajaUsuMonedas]
ADD CONSTRAINT [FK_tbCajaUsuMonedas_tbCajaUsuario]
    FOREIGN KEY ([idCajaUsuario])
    REFERENCES [dbo].[tbCajaUsuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbCajaUsuMonedas_tbCajaUsuario'
CREATE INDEX [IX_FK_tbCajaUsuMonedas_tbCajaUsuario]
ON [dbo].[tbCajaUsuMonedas]
    ([idCajaUsuario]);
GO

-- Creating foreign key on [idMoneda] in table 'tbCajaUsuMonedas'
ALTER TABLE [dbo].[tbCajaUsuMonedas]
ADD CONSTRAINT [FK_tbCajaUsuMonedas_tbMonedas]
    FOREIGN KEY ([idMoneda])
    REFERENCES [dbo].[tbMonedas]
        ([idMoneda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id_categoria] in table 'tbProducto'
ALTER TABLE [dbo].[tbProducto]
ADD CONSTRAINT [FK_tbProducto_tbCategoriaProducto]
    FOREIGN KEY ([id_categoria])
    REFERENCES [dbo].[tbCategoriaProducto]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbProducto_tbCategoriaProducto'
CREATE INDEX [IX_FK_tbProducto_tbCategoriaProducto]
ON [dbo].[tbProducto]
    ([id_categoria]);
GO

-- Creating foreign key on [tipoId], [id] in table 'tbClientes'
ALTER TABLE [dbo].[tbClientes]
ADD CONSTRAINT [FK_tbCliente_tbPersona]
    FOREIGN KEY ([tipoId], [id])
    REFERENCES [dbo].[tbPersona]
        ([tipoId], [identificacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tipoCliente] in table 'tbClientes'
ALTER TABLE [dbo].[tbClientes]
ADD CONSTRAINT [FK_tbClientes_tbTipoClientes]
    FOREIGN KEY ([tipoCliente])
    REFERENCES [dbo].[tbTipoClientes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbClientes_tbTipoClientes'
CREATE INDEX [IX_FK_tbClientes_tbTipoClientes]
ON [dbo].[tbClientes]
    ([tipoCliente]);
GO

-- Creating foreign key on [idCliente], [tipoCliente] in table 'tbCreditos'
ALTER TABLE [dbo].[tbCreditos]
ADD CONSTRAINT [FK_tbCreditos_tbClientes]
    FOREIGN KEY ([idCliente], [tipoCliente])
    REFERENCES [dbo].[tbClientes]
        ([id], [tipoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbCreditos_tbClientes'
CREATE INDEX [IX_FK_tbCreditos_tbClientes]
ON [dbo].[tbCreditos]
    ([idCliente], [tipoCliente]);
GO

-- Creating foreign key on [idCliente], [tipoIdCliente] in table 'tbFactura'
ALTER TABLE [dbo].[tbFactura]
ADD CONSTRAINT [FK_tbFactura_tbClientes]
    FOREIGN KEY ([idCliente], [tipoIdCliente])
    REFERENCES [dbo].[tbClientes]
        ([id], [tipoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbFactura_tbClientes'
CREATE INDEX [IX_FK_tbFactura_tbClientes]
ON [dbo].[tbFactura]
    ([idCliente], [tipoIdCliente]);
GO

-- Creating foreign key on [idMov] in table 'tbCreditos'
ALTER TABLE [dbo].[tbCreditos]
ADD CONSTRAINT [FK_tbCreditos_tbMovimientos]
    FOREIGN KEY ([idMov])
    REFERENCES [dbo].[tbMovimientos]
        ([idMovimiento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbCreditos_tbMovimientos'
CREATE INDEX [IX_FK_tbCreditos_tbMovimientos]
ON [dbo].[tbCreditos]
    ([idMov]);
GO

-- Creating foreign key on [idFactura] in table 'tbDetalleFactura'
ALTER TABLE [dbo].[tbDetalleFactura]
ADD CONSTRAINT [FK_tbDetalleFactura_tbFactura]
    FOREIGN KEY ([idFactura])
    REFERENCES [dbo].[tbFactura]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbDetalleFactura_tbFactura'
CREATE INDEX [IX_FK_tbDetalleFactura_tbFactura]
ON [dbo].[tbDetalleFactura]
    ([idFactura]);
GO

-- Creating foreign key on [idProducto] in table 'tbDetalleFactura'
ALTER TABLE [dbo].[tbDetalleFactura]
ADD CONSTRAINT [FK_tbDetalleFactura_tbProducto]
    FOREIGN KEY ([idProducto])
    REFERENCES [dbo].[tbProducto]
        ([idProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbDetalleFactura_tbProducto'
CREATE INDEX [IX_FK_tbDetalleFactura_tbProducto]
ON [dbo].[tbDetalleFactura]
    ([idProducto]);
GO

-- Creating foreign key on [idIngrediente] in table 'tbDetalleMovimiento'
ALTER TABLE [dbo].[tbDetalleMovimiento]
ADD CONSTRAINT [FK_tbDetalleMovimiento_tbIngredientes]
    FOREIGN KEY ([idIngrediente])
    REFERENCES [dbo].[tbIngredientes]
        ([idIngrediente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbDetalleMovimiento_tbIngredientes'
CREATE INDEX [IX_FK_tbDetalleMovimiento_tbIngredientes]
ON [dbo].[tbDetalleMovimiento]
    ([idIngrediente]);
GO

-- Creating foreign key on [idMov] in table 'tbDetalleMovimiento'
ALTER TABLE [dbo].[tbDetalleMovimiento]
ADD CONSTRAINT [FK_tbDetalleMovimiento_tbMovimientos]
    FOREIGN KEY ([idMov])
    REFERENCES [dbo].[tbMovimientos]
        ([idMovimiento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbDetalleMovimiento_tbMovimientos'
CREATE INDEX [IX_FK_tbDetalleMovimiento_tbMovimientos]
ON [dbo].[tbDetalleMovimiento]
    ([idMov]);
GO

-- Creating foreign key on [idIngrediente] in table 'tbDetalleProducto'
ALTER TABLE [dbo].[tbDetalleProducto]
ADD CONSTRAINT [FK_tbDetalleProducto_tbIngredientes]
    FOREIGN KEY ([idIngrediente])
    REFERENCES [dbo].[tbIngredientes]
        ([idIngrediente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbDetalleProducto_tbIngredientes'
CREATE INDEX [IX_FK_tbDetalleProducto_tbIngredientes]
ON [dbo].[tbDetalleProducto]
    ([idIngrediente]);
GO

-- Creating foreign key on [idProducto] in table 'tbDetalleProducto'
ALTER TABLE [dbo].[tbDetalleProducto]
ADD CONSTRAINT [FK_tbDetalleProducto_tbProducto]
    FOREIGN KEY ([idProducto])
    REFERENCES [dbo].[tbProducto]
        ([idProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbDetalleProducto_tbProducto'
CREATE INDEX [IX_FK_tbDetalleProducto_tbProducto]
ON [dbo].[tbDetalleProducto]
    ([idProducto]);
GO

-- Creating foreign key on [tipoId], [id] in table 'tbEmpleado'
ALTER TABLE [dbo].[tbEmpleado]
ADD CONSTRAINT [FK_tbEmpleado_tbPersona]
    FOREIGN KEY ([tipoId], [id])
    REFERENCES [dbo].[tbPersona]
        ([tipoId], [identificacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idPuesto] in table 'tbEmpleado'
ALTER TABLE [dbo].[tbEmpleado]
ADD CONSTRAINT [FK_tbEmpleado_tbTipoPuesto]
    FOREIGN KEY ([idPuesto])
    REFERENCES [dbo].[tbTipoPuesto]
        ([idTipoPuesto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbEmpleado_tbTipoPuesto'
CREATE INDEX [IX_FK_tbEmpleado_tbTipoPuesto]
ON [dbo].[tbEmpleado]
    ([idPuesto]);
GO

-- Creating foreign key on [idEmpleado], [tipoId] in table 'tbPagos'
ALTER TABLE [dbo].[tbPagos]
ADD CONSTRAINT [FK_tbPagos_tbEmpleado]
    FOREIGN KEY ([idEmpleado], [tipoId])
    REFERENCES [dbo].[tbEmpleado]
        ([id], [tipoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbPagos_tbEmpleado'
CREATE INDEX [IX_FK_tbPagos_tbEmpleado]
ON [dbo].[tbPagos]
    ([idEmpleado], [tipoId]);
GO

-- Creating foreign key on [idProveedor], [idTipo] in table 'tbHorarioProveedor'
ALTER TABLE [dbo].[tbHorarioProveedor]
ADD CONSTRAINT [FK_tbHorarioProveedor_tbProveedores]
    FOREIGN KEY ([idProveedor], [idTipo])
    REFERENCES [dbo].[tbProveedores]
        ([id], [tipoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idTipoIngrediente] in table 'tbIngredientes'
ALTER TABLE [dbo].[tbIngredientes]
ADD CONSTRAINT [FK_tbIngredientes_tbTipoIngrediente]
    FOREIGN KEY ([idTipoIngrediente])
    REFERENCES [dbo].[tbTipoIngrediente]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbIngredientes_tbTipoIngrediente'
CREATE INDEX [IX_FK_tbIngredientes_tbTipoIngrediente]
ON [dbo].[tbIngredientes]
    ([idTipoIngrediente]);
GO

-- Creating foreign key on [idTipoMedida] in table 'tbIngredientes'
ALTER TABLE [dbo].[tbIngredientes]
ADD CONSTRAINT [FK_tbIngredientes_tbTipoMedidas]
    FOREIGN KEY ([idTipoMedida])
    REFERENCES [dbo].[tbTipoMedidas]
        ([idTipoMedida])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbIngredientes_tbTipoMedidas'
CREATE INDEX [IX_FK_tbIngredientes_tbTipoMedidas]
ON [dbo].[tbIngredientes]
    ([idTipoMedida]);
GO

-- Creating foreign key on [idIngrediente] in table 'tbInventario'
ALTER TABLE [dbo].[tbInventario]
ADD CONSTRAINT [FK_tbInventario_tbIngredientes]
    FOREIGN KEY ([idIngrediente])
    REFERENCES [dbo].[tbIngredientes]
        ([idIngrediente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbInventario_tbIngredientes'
CREATE INDEX [IX_FK_tbInventario_tbIngredientes]
ON [dbo].[tbInventario]
    ([idIngrediente]);
GO

-- Creating foreign key on [idTipoMoneda] in table 'tbMonedas'
ALTER TABLE [dbo].[tbMonedas]
ADD CONSTRAINT [FK_tbMonedas_tbTipoMoneda]
    FOREIGN KEY ([idTipoMoneda])
    REFERENCES [dbo].[tbTipoMoneda]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbMonedas_tbTipoMoneda'
CREATE INDEX [IX_FK_tbMonedas_tbTipoMoneda]
ON [dbo].[tbMonedas]
    ([idTipoMoneda]);
GO

-- Creating foreign key on [idTipoMov] in table 'tbMovimientos'
ALTER TABLE [dbo].[tbMovimientos]
ADD CONSTRAINT [FK_tbMovimientos_tbTipoMovimiento]
    FOREIGN KEY ([idTipoMov])
    REFERENCES [dbo].[tbTipoMovimiento]
        ([idTipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbMovimientos_tbTipoMovimiento'
CREATE INDEX [IX_FK_tbMovimientos_tbTipoMovimiento]
ON [dbo].[tbMovimientos]
    ([idTipoMov]);
GO

-- Creating foreign key on [idMovimiento] in table 'tbPagos'
ALTER TABLE [dbo].[tbPagos]
ADD CONSTRAINT [FK_tbPagos_tbMovimientos]
    FOREIGN KEY ([idMovimiento])
    REFERENCES [dbo].[tbMovimientos]
        ([idMovimiento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbPagos_tbMovimientos'
CREATE INDEX [IX_FK_tbPagos_tbMovimientos]
ON [dbo].[tbPagos]
    ([idMovimiento]);
GO

-- Creating foreign key on [tipoId], [id] in table 'tbProveedores'
ALTER TABLE [dbo].[tbProveedores]
ADD CONSTRAINT [FK_tbProveedores_tbPersona]
    FOREIGN KEY ([tipoId], [id])
    REFERENCES [dbo].[tbPersona]
        ([tipoId], [identificacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tipoId], [id] in table 'tbUsuarios'
ALTER TABLE [dbo].[tbUsuarios]
ADD CONSTRAINT [FK_tbUsuarios_tbPersona]
    FOREIGN KEY ([tipoId], [id])
    REFERENCES [dbo].[tbPersona]
        ([tipoId], [identificacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idRol] in table 'tbUsuarios'
ALTER TABLE [dbo].[tbUsuarios]
ADD CONSTRAINT [FK_tbUsuarios_tbRoles]
    FOREIGN KEY ([idRol])
    REFERENCES [dbo].[tbRoles]
        ([idRol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbUsuarios_tbRoles'
CREATE INDEX [IX_FK_tbUsuarios_tbRoles]
ON [dbo].[tbUsuarios]
    ([idRol]);
GO

-- Creating foreign key on [tbIngredientes_idIngrediente] in table 'tbIngredienteProveedor'
ALTER TABLE [dbo].[tbIngredienteProveedor]
ADD CONSTRAINT [FK_tbIngredienteProveedor_tbIngredientes]
    FOREIGN KEY ([tbIngredientes_idIngrediente])
    REFERENCES [dbo].[tbIngredientes]
        ([idIngrediente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tbProveedores_id], [tbProveedores_tipoId] in table 'tbIngredienteProveedor'
ALTER TABLE [dbo].[tbIngredienteProveedor]
ADD CONSTRAINT [FK_tbIngredienteProveedor_tbProveedores]
    FOREIGN KEY ([tbProveedores_id], [tbProveedores_tipoId])
    REFERENCES [dbo].[tbProveedores]
        ([id], [tipoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbIngredienteProveedor_tbProveedores'
CREATE INDEX [IX_FK_tbIngredienteProveedor_tbProveedores]
ON [dbo].[tbIngredienteProveedor]
    ([tbProveedores_id], [tbProveedores_tipoId]);
GO

-- Creating foreign key on [tbCajaUsuario_id] in table 'tbMovimientoCajaUsuario'
ALTER TABLE [dbo].[tbMovimientoCajaUsuario]
ADD CONSTRAINT [FK_tbMovimientoCajaUsuario_tbCajaUsuario]
    FOREIGN KEY ([tbCajaUsuario_id])
    REFERENCES [dbo].[tbCajaUsuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tbMovimientos_idMovimiento] in table 'tbMovimientoCajaUsuario'
ALTER TABLE [dbo].[tbMovimientoCajaUsuario]
ADD CONSTRAINT [FK_tbMovimientoCajaUsuario_tbMovimientos]
    FOREIGN KEY ([tbMovimientos_idMovimiento])
    REFERENCES [dbo].[tbMovimientos]
        ([idMovimiento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbMovimientoCajaUsuario_tbMovimientos'
CREATE INDEX [IX_FK_tbMovimientoCajaUsuario_tbMovimientos]
ON [dbo].[tbMovimientoCajaUsuario]
    ([tbMovimientos_idMovimiento]);
GO

-- Creating foreign key on [tbRequerimientos_idReq] in table 'tbPermisos'
ALTER TABLE [dbo].[tbPermisos]
ADD CONSTRAINT [FK_tbPermisos_tbRequerimientos]
    FOREIGN KEY ([tbRequerimientos_idReq])
    REFERENCES [dbo].[tbRequerimientos]
        ([idReq])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tbRoles_idRol] in table 'tbPermisos'
ALTER TABLE [dbo].[tbPermisos]
ADD CONSTRAINT [FK_tbPermisos_tbRoles]
    FOREIGN KEY ([tbRoles_idRol])
    REFERENCES [dbo].[tbRoles]
        ([idRol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbPermisos_tbRoles'
CREATE INDEX [IX_FK_tbPermisos_tbRoles]
ON [dbo].[tbPermisos]
    ([tbRoles_idRol]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------