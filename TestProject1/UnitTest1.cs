using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    public class CRUDTests
    {
        [Test]
        public void TambahData_ShouldAddItem()
        {
            // Arrange
            List<string> data = new List<string>();
            string newData = "Test Data";

            // Act
            data.Add(newData);

            // Assert
            Assert.AreEqual(1, data.Count);
            Assert.AreEqual(newData, data[0]);
        }

        [Test]
        public void EditData_ShouldModifyItem()
        {
            // Arrange
            List<string> data = new List<string> { "Data 1", "Data 2", "Data 3" };
            string newData = "Modified Data";

            // Act
            int index = 1; // Edit Data 2
            data[index] = newData;

            // Assert
            Assert.AreEqual(3, data.Count);
            Assert.AreEqual(newData, data[index]);
        }

        [Test]
        public void HapusData_ShouldRemoveItem()
        {
            // Arrange
            List<string> data = new List<string> { "Data 1", "Data 2", "Data 3" };

            // Act
            int index = 1; // Hapus Data 2
            data.RemoveAt(index);

            // Assert
            Assert.AreEqual(2, data.Count);
            CollectionAssert.DoesNotContain(data, "Data 2");
        }
    }
}