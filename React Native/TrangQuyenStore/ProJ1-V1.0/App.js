import React from 'react';
import { StyleSheet } from 'react-native';
import { createAppContainer } from 'react-navigation';

//my lib
import AppNavigator from './AppNavigator';

const AppContainer = createAppContainer(AppNavigator);

export default class App extends React.Component {
  render() {
    return <AppContainer />;
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'stretch', //alignItems: 'stretch' can le tran 2 ben
    backgroundColor: '#fff',
    justifyContent: 'center',
    paddingLeft: 16,
    paddingRight: 16,

  },
});



// //alert test
// import React, { useState } from "react";
// import { View, Button, StyleSheet, Alert } from "react-native";

// export default function App() {
//   const [showBox, setShowBox] = useState(true);

//   const showConfirmDialog = () => {
//     return Alert.alert(
//       "Are your sure?",
//       "Are you sure you want to remove this beautiful box?",
//       [
//         // The "Yes" button
//         {
//           text: "Yes",
//           onPress: () => {
//             setShowBox(false);
//           },
//         },
//         // The "No" button
//         // Does nothing but dismiss the dialog when tapped
//         {
//           text: "No",
//         },
//       ]
//     );
//   };

//   return (
//     <View style={styles.screen}>
//       {showBox && <View style={styles.box}></View>}
//       <Button title="Delete" onPress={() => showConfirmDialog()} />
//     </View>
//   );
// }

// // Kindacode.com
// // Just some styles
// const styles = StyleSheet.create({
//   screen: {
//     flex: 1,
//     justifyContent: "center",
//     alignItems: "center",
//   },
//   box: {
//     width: 300,
//     height: 300,
//     backgroundColor: "red",
//     marginBottom: 30,
//   },
//   text: {
//     fontSize: 30,
//   },
// });


///alert (dialog)
// Alert.alert(
//   "Are your sure?",
//   "Are you sure you want to remove this beautiful box?",
//   [
//     // The "Yes" button
//     {
//       text: "Yes",
//       onPress: () => {
//         setShowBox(false);
//       },
//     },
//     // The "No" button
//     // Does nothing but dismiss the dialog when tapped
//     {
//       text: "No",
//     },
//   ]
// );