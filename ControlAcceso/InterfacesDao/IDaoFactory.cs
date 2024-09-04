using GenericAccesoDatos;



namespace ControlAcceso.InterfacesDao
{
  public   interface IDaoFactory
    {
       IUsuarioDao  getUsuarioDAO(ISessionProvider sessionProvider);
       IPrivilegioDao  getPrivilegioDAO(ISessionProvider sessionProvider);
       IUsuarioPrivilegioDao getUsuarioPrivilegioDAO(ISessionProvider sessionProvider);
    }
}
