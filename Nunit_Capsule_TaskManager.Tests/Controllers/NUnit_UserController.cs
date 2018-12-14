﻿using Capsule_TaskManager.Controllers;
using Capsule_TaskManager.Models.User;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Capsule_TaskManager.Tests.Controllers
{
    [TestFixture]
    public class NUnit_UserController
    {
        #region Public Declaration

        UserController objUserController = new UserController();

        #endregion

        #region GetUserDetails
        /// <summary>
        /// To get User details
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserDetails()
        {
            var vlsit = objUserController.GetUserDetails();
            Assert.IsTrue(vlsit != null);
        }
        #endregion

        #region SubmitUserDetail
        /// <summary>
        /// Insert the User details which user entered
        /// </summary>
        /// <param name="objGET_User_DETAILS_Result"></param>
        /// <returns></returns>
        [Test, Order(1)]
        public void InsertUserDetail()
        {
            UserModel userModel = new UserModel();
            userModel.User_ID = 0;
            userModel.First_Name = "Rajasekar";
            userModel.Last_Name = "Veerapandian";
            userModel.Employee_ID = 512924;

             var isInserted = objUserController.SubmitUserDetail(userModel);
            Assert.IsTrue(isInserted);
        }

        [Test]
        public void UpdateUserDetail()
        {
            UserModel userModel = new UserModel();
            userModel.User_ID = 4;
            userModel.First_Name = "Rajasekar";
            userModel.Last_Name = "Veerapandian";
            userModel.Employee_ID = 512924;
            
            var isUpdated = objUserController.SubmitUserDetail(userModel);
            Assert.IsTrue(isUpdated);
        }
        #endregion

        #region DeleteUserDetail

      /// <summary>
      /// 
      /// </summary>
      /// <param name="userModel"></param>
      /// <returns></returns>
        [Test]
        public void DeleteUserDetail()
        {
            UserModel userModel = new UserModel();
            userModel.User_ID = 3;
             var vDeleteUserDetails = objUserController.DeleteUserDetail(userModel);
            Assert.IsTrue(vDeleteUserDetails);
        }

        #endregion
    }
}
