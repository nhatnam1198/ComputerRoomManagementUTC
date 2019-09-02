using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Common
{
    public class StoredProcedureConfigs<T>
    {
        private const string _insert_single_stored_procedure = "_insert_single_stored_procedure";
        private const string _insert_list_stored_procedure = "_insert_list_stored_procedure";
        private const string _update_single_stored_procedure = "_update_single_stored_procedure";
        private const string _update_list_stored_procedure = "_update_list_stored_procedure";
        private const string _delete_single_stored_procedure = "_delete_single_stored_procedure";
        private const string _delete_list_stored_procedure = "_delete_list_stored_procedure";
        private const string _get_single_stored_procedure = "_get_single_stored_procedure";
        private const string _get_paging_stored_procedure = "_get_paging_stored_procedure";
        private const string _get_all_stored_procedure = "_get_all_stored_procedure";

        public string _INSERT_SINGLE_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _insert_single_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _INSERT_LIST_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _insert_list_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _UPDATE_SINGLE_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _update_single_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _UPDATE_LIST_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _update_list_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _DELETE_SINGLE_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _delete_single_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _DELETE_LIST_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _delete_list_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _GET_SINGLE_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _get_single_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _GET_PAGING_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _get_paging_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        public string _GET_ALL_STORED_PROCEDURE
        {
            get
            {
                var propertyName = string.Format("{0}_{1}", _get_all_stored_procedure, typeof(T).Name);
                string storedProcedureName = this.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this, null).ToString();
                return storedProcedureName;
            }
        }

        #region INSERT
        private string _insert_single_stored_procedure_RAM
        {
            get
            {
                return "[dbo].[RAM_INSERT]";
            }
        }
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion

        #region GETPAGING
        private string _get_paging_stored_procedure_RAM
        {
            get
            {
                return "[dbo].[RAM_GET_PAGING]";
            }
        }
        #endregion

        #region GETSINGLE
        #endregion

        #region GETALL
        private string _get_all_stored_procedure_RAM
        {
            get
            {
                return "[dbo].[RAM_GET_ALL]";
            }
        }
        #endregion

    }
}
