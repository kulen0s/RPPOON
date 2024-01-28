using _4._domaca_zadaca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._domaca_zadaca
{
    interface IPermission
    {
        public void Allow();
    }
    public class EditPermission : IPermission
    {
        public void Allow()
        { Console.WriteLine("User Has Edit Permission"); }
    }
    public class DeletePermission : IPermission
    {
        public void Allow()
        { Console.WriteLine("User Has Delete Permission"); }
    }
    public class CreatePermission : IPermission
    {
        public void Allow()
        { Console.WriteLine("User Has Create Permission"); }
    }
    public class ViewPermission : IPermission
    {
        public void Allow()
        { Console.WriteLine("User Has View Permission"); }
    }
    public interface IAccountConfigurator
    {
        public void AddEditPermission(EditPermission permission);
        public void AddDeletePermission(DeletePermission permission);
        public void AddCreatePermission(CreatePermission permission);
        public void AddViewPermission(ViewPermission permission);
        public void ClearPermissions();
    }

    public class PresetPermissions : IAccountConfigurator
    {
        private List<IPermission> permissions = new List<IPermission>();

        public void AddEditPermission(EditPermission permission)
        {
            permissions.Add(permission);
        }

        public void AddDeletePermission(DeletePermission permission)
        {
            permissions.Add(permission);
        }

        public void AddCreatePermission(CreatePermission permission)
        {
            permissions.Add(permission);
        }

        public void AddViewPermission(ViewPermission permission)
        {
            permissions.Add(permission);
        }

        public void ClearPermissions()
        {
            permissions.Clear();
        }
    }

    public class PresetPermissionsBuilder
    {
        private PresetPermissions presetPermissions = new PresetPermissions();

        public PresetPermissionsBuilder AddAdminPermissions()
        {
            presetPermissions.AddEditPermission(new EditPermission());
            presetPermissions.AddDeletePermission(new DeletePermission());
            presetPermissions.AddCreatePermission(new CreatePermission());
            presetPermissions.AddViewPermission(new ViewPermission());
            return this;
        }

        public PresetPermissionsBuilder AddUserPermissions()
        {
            presetPermissions.AddViewPermission(new ViewPermission());
            return this;
        }

        public PresetPermissionsBuilder AddManagerPermissions()
        {
            presetPermissions.AddEditPermission(new EditPermission());
            presetPermissions.AddCreatePermission(new CreatePermission());
            presetPermissions.AddViewPermission(new ViewPermission());
            return this;
        }

        public PresetPermissions Build()
        {
            return presetPermissions;
        }
    }

    class Program
    {
        static void Main()
        {
            PresetPermissions adminPermissions = new PresetPermissionsBuilder().AddAdminPermissions().Build();
            PresetPermissions userPermissions = new PresetPermissionsBuilder().AddUserPermissions().Build();
            PresetPermissions managerPermissions = new PresetPermissionsBuilder().AddManagerPermissions().Build();
        }
    }
}
