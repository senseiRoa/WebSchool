CREATE procedure [dbo].[SP_LoadMenuByUser](@idUser uniqueidentifier)
as begin
			SELECT        T_Menu.*
			FROM            T_Permission INNER JOIN
									 T_Menu ON T_Permission.MenuID = T_Menu.MenuID INNER JOIN
									 AspNetUserRoles ON T_Permission.RoleID = AspNetUserRoles.RoleId
			WHERE        (AspNetUserRoles.UserId = @idUser) AND (T_Menu.LogicalErasure = 0) AND (T_Permission.LogicalErasure = 0)

			order by 1,3
end
GO