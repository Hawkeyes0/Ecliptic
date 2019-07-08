# 项目划分

## Ecliptic.Entities

系统中的对象实体

## Ecliptic.Spi

系统中的业务服务接口

## Ecliptic.Services

系统业务服务实现

相同的业务服务接口，针对不同的业务需要可能存在不同的实现

## Ecliptic.Workflow

一个简易的工作流组件

## Ecliptic.Portal

部署目录：/

门户框架

负责药店用户的登录、注册、密码找回等操作

负责菜单和首页的显示

## Ecliptic.&lt;Modules&gt;

部署目录：/&lt;Modules&gt;/

功能模块

以登录票进行身份验证

所有涉及业务流程的操作增加时间戳，防止因各种原因导致请求重发造成业务重复处理。